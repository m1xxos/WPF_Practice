﻿#pragma checksum "..\..\..\Pages\AddEditServicePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "152698286688BFD7D859C6E43C8BAF99061CE6F6CFCA2F677EF876BFA063A3F0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MasterApp2021.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MasterApp2021.Pages {
    
    
    /// <summary>
    /// AddEditServicePage
    /// </summary>
    public partial class AddEditServicePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Pages\AddEditServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TboxTitle;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\AddEditServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TboxCost;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\AddEditServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TboxDuration;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\AddEditServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TboxDescription;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\AddEditServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TboxDiscount;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\AddEditServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageService;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Pages\AddEditServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSelectImage;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\AddEditServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MasterApp2021;component/pages/addeditservicepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AddEditServicePage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TboxTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TboxCost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TboxDuration = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TboxDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TboxDiscount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ImageService = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.BtnSelectImage = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Pages\AddEditServicePage.xaml"
            this.BtnSelectImage.Click += new System.Windows.RoutedEventHandler(this.BtnSelectImage_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnSave = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Pages\AddEditServicePage.xaml"
            this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

