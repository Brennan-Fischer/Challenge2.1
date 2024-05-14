using System.ComponentModel.Design;

namespace Challenge2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int readResult;

            do
            {
                Console.WriteLine("Input temperature from 0-80 farenheit to receive qualitative description");
                readResult = Convert.ToInt32(Console.ReadLine());

                if (readResult >= 0 && readResult < 11)
                {
                    Console.WriteLine("Freezing Weather");
                }
                else if (readResult >= 11 && readResult < 21)
                {
                    Console.WriteLine("Very Cold Weather");
                }
                else if (readResult >= 21 && readResult < 36)
                {
                    Console.WriteLine("Cold Weather");
                }
                else if (readResult >= 36 && readResult < 51)
                {
                    Console.WriteLine("Normal Weather");
                }
                else if (readResult >= 51 && readResult < 66)
                {
                    Console.WriteLine("Its Hot");
                }
                else if ((readResult >= 66 && readResult < 81))
                {
                    Console.WriteLine("Its Very Hot");
                }
                else
                {
                    Console.WriteLine("Enter a valid temperature from 0-80");
                }
            }
            while (!(readResult >= 0 && readResult < 81));
            {
                
            }

        }
    }
}
