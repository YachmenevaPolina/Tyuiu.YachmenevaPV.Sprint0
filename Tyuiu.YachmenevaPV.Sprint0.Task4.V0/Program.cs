using Tyuiu.YachmenevaPV.Sprint0.Task4.V0.Lib;
namespace Tyuiu.YachmenevaPV.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //сложение
            Console.WriteLine(DataService.Addition(1, 5));
            //вычитание
            Console.WriteLine(DataService.Subtraction(15, 5));
            //умножение
            Console.WriteLine(DataService.Multiplication(10, 10));
            //деление
            Console.WriteLine(DataService.Division(5, 5));

            Console.ReadKey();
        }
    }
}