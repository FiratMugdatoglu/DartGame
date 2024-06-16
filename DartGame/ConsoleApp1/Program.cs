using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t\t\t\tDART GAME");
            Console.WriteLine();


            Console.Write("Enter the number of darts to be thrown:");
            int numberOfDarts = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();


            Random random = new Random();

            int counterA = 0;
            int counterB = 0;
            int counterC = 0;
            int counterD = 0;

            int i;





            for (i = 1; i <= numberOfDarts; i++)
            {
                // -7 ile 7 arasında rasgele bir tamsayı üretin
                int randomNumberX = random.Next(-7, 8);
                int randomNumberY = random.Next(-7, 8);
                


                Console.WriteLine("Dart " + i + ":");
                Console.WriteLine("Coordinates: " + "(" + randomNumberX + "," + randomNumberY + ")");
                
                if (randomNumberX >= 0 && randomNumberX <= 5 && randomNumberY >= 0 && randomNumberY <= 5)
                {
                    Console.WriteLine("Region: A ");
                     counterA++;
                }
                else if (randomNumberX < 0 && randomNumberX >= -5 && randomNumberY >= 0 && randomNumberY <= 5)
                {
                    Console.WriteLine("Region: B ");
                    counterB++;
                }
                else if (randomNumberX < 0 && randomNumberX >= -5 && randomNumberY < 0 && randomNumberY >= -5)
                {
                    Console.WriteLine("Region: C ");
                    counterC++;
                }
                else if (randomNumberX >= 0 && randomNumberX <= 5 && randomNumberY < 0 && randomNumberY >= -5)
                {
                    Console.WriteLine("Region: D ");
                    counterD++;
                }
                else
                {
                    Console.WriteLine("Region: Missed ");
                    i++;
                    break;
                }

                Console.WriteLine();
                Console.WriteLine();



            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Region statistics:");
            Console.WriteLine("Total Game: " + (i - 1));
            Console.WriteLine("A: " + counterA + " dart(s) " + "(" + ((100.0 * counterA / (i - 1)).ToString("F2")) + "%)");
            Console.WriteLine("B: " + counterB + " dart(s) " + "(" + ((100.0 * counterB / (i - 1)).ToString("F2")) + "%)");
            Console.WriteLine("C: " + counterC + " dart(s) " + "(" + ((100.0 * counterC / (i - 1)).ToString("F2")) + "%)");
            Console.WriteLine("D: " + counterD + " dart(s) " + "(" + ((100.0 * counterD / (i - 1)).ToString("F2")) + "%)");




            Console.ReadLine();


        }
    }
}
