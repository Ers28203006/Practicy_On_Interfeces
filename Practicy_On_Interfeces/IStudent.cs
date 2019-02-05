using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicy_On_Interfeces
{
    interface IStudent
    {
        string GroupName { get; set; }
         string this[int index]
        {
            get;
            set;
        }
        void ListOfStudents();
    }
}
