using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicy_On_Interfeces
{
    class StudentGroup : IStudent
    {
        private string[] _studentsSurnameAndFirsName;
        private string _groupName;
        private int _numberOfGroup;
        public StudentGroup(int numberOfGroup)
        {
            _studentsSurnameAndFirsName = new string[numberOfGroup];
            _numberOfGroup = numberOfGroup;
        }
        public string GroupName
        {
            get
            {
                return _groupName;
            }
            set
            {
                _groupName = value;
            }
        }

        public string this[int index]
        {
            get
            {
                return _studentsSurnameAndFirsName[index];
            }
            set
            {
                _studentsSurnameAndFirsName[index] = value;
            }
        }

        public void ListOfStudents()
        {
            Console.WriteLine("Список студентов группы "+ _groupName+ ": ");

            for (int i = 0; i < _numberOfGroup; i++)
            {
                Console.WriteLine(i+1 + ". " + _studentsSurnameAndFirsName[i]);
            }
        }

    }
}
