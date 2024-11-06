
namespace NcCsTypes
{
    internal class Task02
    {
        public static void Run()
        {
            int intInput = int.Parse(Console.ReadLine());
            decimal decimalInput = decimal.Parse(Console.ReadLine());

            double result = intInput / (double)decimalInput;

            Console.WriteLine(result);
        }
    }
}
