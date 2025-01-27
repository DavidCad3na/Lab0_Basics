using System.Diagnostics.Metrics;

namespace lab0_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Intake
            Console.Write("Please enter a low number: ");
            int lowNumber = Convert.ToInt32(Console.ReadLine());
            while (lowNumber < 0)
            {
                Console.Write("\nPlease enter a positive number: ");
                lowNumber = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Please enter a high number: ");
            int highNumber = Convert.ToInt32(Console.ReadLine());

            //input validation for a positive low number
            while (lowNumber < 0)
            {
                Console.Write("Please enter a positive value: ");
                lowNumber = Convert.ToInt32(Console.ReadLine());
            }

            //input validation for high number
            while (lowNumber >= highNumber)
            {
                Console.Write("Please enter a higher number than your low value: ");
                highNumber = Convert.ToInt32(Console.ReadLine());
            }

            //Get Differance
            int difference = highNumber - lowNumber;
            Console.WriteLine($"The differance between the numbers is {difference}");

            int[] logNum = new int[difference + 1];
            int Index = 0;

            //Normal and Print
            Console.WriteLine("\nNormal: ");
            for (int track = lowNumber; track <= highNumber; track++)
            {
                logNum[Index] = track;
                Index++;
            }

            foreach (int num in logNum)
            {
                Console.Write(num + " ");
            }

            //Inverse and Print
            string filePath = "C:\\Users\\caden\\code\\oob2\\C#\\class\\lab0_Basics\\numbers.txt";
            int[] logNumInverse = new int[difference + 1];
            int indexInverse = 0;
            string inverse = "";

            Console.WriteLine("\n\nInverse: ");
            for (int trackInverse = highNumber; trackInverse >= lowNumber; trackInverse--)
            {
                logNumInverse[indexInverse] = trackInverse;
                indexInverse++;
            }

            foreach (int invertNum in logNumInverse)
            {
                Console.Write(invertNum + " ");
            }

            //Write to file
            foreach (int invertNum in logNumInverse)
            {
                inverse = Convert.ToString(invertNum);
                File.AppendAllText(filePath, inverse + " ");
            }
            Console.Write("\n\nFile Written to numbers.txt in program folder.\n");
        }
    }
}
