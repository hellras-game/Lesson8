using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Task_1
{
    class Program
        {
            /*Выполнила Ярмолинская Анастасия
            С помощью рефлексии выведите все свойства структуры DateTime*/
            static void Main(string[] args)
                {
                Type dateTime = typeof(DateTime);
                foreach (var property in dateTime.GetProperties())
                {
                    Console.WriteLine($"{property.Name} - {property.PropertyType}");
                }
                }
        }
}
