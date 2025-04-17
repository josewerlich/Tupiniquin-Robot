
namespace Tupiniquin_Robot
{
    internal class Program
    {
        //Version 1: Menu, user input and movement definitions   
        static void Main(string[] args)
        {
            
            int PositionX = 0;
            int PositionY = 0;
            string PointingPosition;

            Console.WriteLine("********************************************");
            Console.WriteLine("**************Tupiniquin Robot**************");
            Console.WriteLine("********************************************");

            Console.WriteLine("Type the initial position of the Robot:");
            Console.Write("Position X:"); PositionX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Position Y:"); PositionY = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pointing position:"); PointingPosition = Console.ReadLine();

            string input = "MMLMM";

            char[] instructions = input.ToCharArray();

            for (int counter = 0; counter < input.Length; counter++)
            {


                if (instructions[counter].Equals('M'))
                {
                    if (PointingPosition == "N")

                        PositionY++;

                    else if (PointingPosition == "E")
                        PositionX++;

                    else if (PointingPosition == "S")
                        PositionY--;

                    else if (PointingPosition == "W")
                        PositionX--;
                }

               

            }
           
            Console.WriteLine($"Position X: {PositionX}");
            Console.WriteLine($"Position Y: {PositionY}");
            Console.WriteLine($"Point Position: {PointingPosition}"); 
            Console.ReadLine();
        }
    }
}
