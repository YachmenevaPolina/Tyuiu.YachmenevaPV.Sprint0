using Tyuiu.YachmenevaPV.Sprint0.Task6.V0.Lib;
namespace Tyuiu.YachmenevaPV.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            //пример цикл. структуры -> AdditionArray
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArray));
            
            //пример цикл. структуры -> SubtractionArray
            Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(numsArray));

            //пример цикл. структуры -> MultiplicationArray
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();


        }
    }
}