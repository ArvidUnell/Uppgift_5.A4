using System;
namespace Uppgift_5_A4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namnArr = { "Jakob", "Tova", "Johanna", "Molly", "Emilio" };

            byte förstIndex = 0;

            for (int i = 1;i < namnArr.Length; i++)
            {
                if (namnArr[i].CompareTo(namnArr[förstIndex]) < 0)
                {
                    förstIndex = (byte)i;
                }
            }

            Console.WriteLine($"Namnet som kommer först i bokstavsordning är {namnArr[förstIndex]}.");

            Console.WriteLine("\nTryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}