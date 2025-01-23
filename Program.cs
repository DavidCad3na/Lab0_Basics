namespace lab0_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a low number: ");
            int lowNumber = Convert.ToInt32(Console.ReadLine());
            while (lowNumber < 0)
            {
                Console.Write("Positive Number Only fn");
                Console.WriteLine("Please enter a low number: ");
                lowNumber = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Please enter a high number: ");
            int highNumber = Convert.ToInt32(Console.ReadLine());
            while (lowNumber > highNumber)
            {
                Console.Write("Positive Number Only fn");
                Console.Write("Please enter a low number: ");
                lowNumber = Convert.ToInt32(Console.ReadLine());
            }

            int differance = highNumber - lowNumber;
            Console.WriteLine($"The differance between the numbers is {differance}");

        }
    }
}
