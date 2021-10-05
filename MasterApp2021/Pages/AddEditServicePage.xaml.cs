using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MasterApp2021.Pages
{
    /// <summary>
    /// Interaction logic for AddEditServicePage.xaml
    /// </summary>

        public partial class AddEditServicePage : Page
        {
            private Entities.Service _currentService = null;
            private byte[] _mainImageData;
            public AddEditServicePage()
            {
                InitializeComponent();
            }

            public AddEditServicePage(Entities.Service service)
            {
                InitializeComponent();

                _currentService = service;
                Title = "Редактировать услугу";
                TboxTitle.Text = _currentService.Title;
                TboxCost.Text = _currentService.Cost.ToString("N2");
                TboxDuration.Text = (_currentService.DurationInSeconds / 60).ToString();
                TboxDescription.Text = _currentService.Description;
                if (_currentService.Discount > 0)
                    TboxDiscount.Text = (_currentService.Discount.Value * 100).ToString();
                if (_currentService.MainImage != null)
                    ImageService.Source = (ImageSource)new ImageSourceConverter()
                        .ConvertFrom(_currentService.MainImage);
            }

            private void Button_Click(object sender, RoutedEventArgs e)
            {
                NavigationService.GoBack();
            }

            private void BtnSelectImage_Click(object sender, RoutedEventArgs e)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image |*.png; *.jpg; *.jpeg";
                if (ofd.ShowDialog() == true)
                {
                    _mainImageData = File.ReadAllBytes(ofd.FileName);
                    ImageService.Source = (ImageSource)new ImageSourceConverter()
                        .ConvertFrom(_mainImageData);
                }
            }

            private void BtnSave_Click(object sender, RoutedEventArgs e)
            {
                var errorMessage = CheckErrors();
                if (errorMessage.Length > 0)
                {
                    MessageBox.Show(errorMessage, "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if (_currentService == null)
                    {
                        var service = new Entities.Service
                        {
                            Title = TboxTitle.Text,
                            Cost = decimal.Parse(TboxCost.Text),
                            DurationInSeconds = int.Parse(TboxDuration.Text) * 60,
                            Description = TboxDescription.Text,
                            Discount = string.IsNullOrWhiteSpace(TboxDiscount.Text) ? 0 : double.Parse(TboxDiscount.Text) / 100,
                            MainImage = _mainImageData
                        };
                        App.Context.Services.Add(service);
                        App.Context.SaveChanges();
                    }
                    else
                    {
                        _currentService.Title = TboxTitle.Text;
                        _currentService.Cost = decimal.Parse(TboxCost.Text);
                        _currentService.DurationInSeconds = int.Parse(TboxDuration.Text) * 60;
                        _currentService.Discount = string.IsNullOrWhiteSpace(TboxDiscount.Text) ? 0 : double.Parse(TboxDiscount.Text) / 100;
                        if (_mainImageData != null)
                            _currentService.MainImage = _mainImageData;
                        App.Context.SaveChanges();
                    }

                    NavigationService.GoBack();
                }
            }

            private string CheckErrors()
            {
                var errorBuilder = new StringBuilder();
                if (string.IsNullOrWhiteSpace(TboxTitle.Text))
                    errorBuilder.AppendLine("Название услуги обязательно для заполнения;");

                var serviceFromDB = App.Context.Services.ToList()
                    .FirstOrDefault(p => p.Title.ToLower() == TboxTitle.Text.ToLower());
                if (serviceFromDB != null && serviceFromDB != _currentService)
                    errorBuilder.AppendLine("Такая услуга уже есть в базе данных");

                decimal cost = 0;
                if (decimal.TryParse(TboxCost.Text, out cost) == false
                    || cost <= 0)
                    errorBuilder.AppendLine("Стоимость услуги должна быть положительным числом;");

                int durationInMinutes = 0;
                if (int.TryParse(TboxDuration.Text, out durationInMinutes) == false
                    || durationInMinutes > 240
                    || durationInMinutes <= 0)
                {
                    errorBuilder.AppendLine("Длительность оказания услуги должна быть положительным числом (не больше, чем 4 часа);");
                }

                if (!string.IsNullOrEmpty(TboxDiscount.Text))
                {
                    int discount = 0;
                    if (int.TryParse(TboxDiscount.Text, out discount) == false || discount < 0 || discount > 100)
                    {
                        errorBuilder.AppendLine("Размер скидки - целое число в диапазоне от 0 до 100%;");
                    }
                }

                if (errorBuilder.Length > 0)
                    errorBuilder.Insert(0, "Устраните следующие ошибки:\n");

                return errorBuilder.ToString();
            }
        }
    }
