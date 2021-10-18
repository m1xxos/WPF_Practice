using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restate.Entities
{
    public partial class PersonSet
    {
        public string FullName 
        {
            get
            {
                return FirstName  + " " + MiddleName + " " + LastName;
            }
        }
    }
}
