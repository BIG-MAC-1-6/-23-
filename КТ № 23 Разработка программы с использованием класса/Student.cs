using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ___23_Разработка_программы_с_использованием_класса
{
    public class MyClass
    {
        public int Value1;
        public int Value2; 

        // Конструктор
        public MyClass(int value1, int value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        //Вывод значений
        public void PrintValues()
        {
            Console.WriteLine($"Значение 1: {Value1}, Значение 2: {Value2}");
        }

        //Изменение переменных
        public void ChangeValues(int newValue1, int newValue2)
        {
            Value1 = newValue1;
            Value2 = newValue2;
        }

        public int Sum()
        {
            return Value1 + Value2;
        }

        public int Max()
        {
            return Math.Max(Value1, Value2);
        }
    }
}
