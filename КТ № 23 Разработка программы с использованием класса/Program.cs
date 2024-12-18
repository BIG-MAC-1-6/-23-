using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ___23_Разработка_программы_с_использованием_класса
{
    public class Example
    {
        public static void Main(string[] args)
        {
            MyClass myObject = new MyClass(10, 5);// Создание знач.
            myObject.PrintValues();//Вывод знач.
            Console.WriteLine($"Сумма: {myObject.Sum()}");
            Console.WriteLine($"Наибольшее значение: {myObject.Max()}");



            myObject.ChangeValues(20, 15);//Изминение знач.
            myObject.PrintValues();//Вывод нов. знач.
            Console.WriteLine($"Сумма: {myObject.Sum()}"); 
            Console.WriteLine($"Наибольшее значение: {myObject.Max()}");
            Console.ReadKey();
        }
    }
}
