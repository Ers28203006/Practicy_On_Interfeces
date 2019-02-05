using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicy_On_Interfeces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество человек в группе: ");
            int numberOfGroups = int.Parse(Console.ReadLine());

            StudentGroup studentGroup = new StudentGroup(numberOfGroups);

            Random random = new Random();

            char[] oneNameStudent;
            int countSymbolInName;

            for (int i = 0; i < numberOfGroups; i++)
            {
                countSymbolInName = random.Next(15, 20);
                oneNameStudent = new char[countSymbolInName];
                for (int j = 0; j < countSymbolInName; j++)
                {
                    oneNameStudent[j] = Convert.ToChar(random.Next('а', 'я'));
                   
                }
                oneNameStudent[0]= char.ToUpper(oneNameStudent[0]);
                oneNameStudent[6] = ' ' ;
                oneNameStudent[7] = char.ToUpper(oneNameStudent[0]);


                studentGroup[i] = new string(oneNameStudent);
            }

            studentGroup.GroupName = "ATP-02-2";

            studentGroup.ListOfStudents();
            Console.ReadLine();
        }
    }
}
