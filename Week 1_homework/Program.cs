using System;

namespace Week_1_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            decimal TheFirstAddVariable = 6M; // 6
            decimal TheSecondAddVariable = TheFirstAddVariable * TheFirstAddVariable; // квадрат 6-ти
            decimal TheThirdAddVariable = TheSecondAddVariable - 1; // квадрат 6-ти - 1
            decimal x = TheThirdAddVariable / 2; // искомое значение (квадрат 6-ти - 1)/2
            

            Console.WriteLine($"Результат вычисления : {x}");
        }
    }
}
