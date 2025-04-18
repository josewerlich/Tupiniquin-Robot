
namespace Tupiniquin_Robot
{
    internal partial class Program
    {
        //Version 4: Creation of the Class Robot - Object-Oriented with Two Rovers, Kay and ExAshTwelve.
        static void Main(string[] args)
        {
            Robot KaiRover = new Robot();

            ShowMenu();

            Console.Write("Position X:"); KaiRover.PositionX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Position Y:"); KaiRover.PositionY = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pointing position:"); KaiRover.PointingPosition = Console.ReadLine();

            string input = "LMLMLMLMM";

            char[] instructions = input.ToCharArray();

            KaiRover.Explore(instructions);

            KaiRover.ShowLocation();

            ShowMenu();

            Robot ExAshTwelveRover = new Robot();

            Console.Write("Position X:"); ExAshTwelveRover.PositionX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Position Y:"); ExAshTwelveRover.PositionY = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pointing position:"); ExAshTwelveRover.PointingPosition = Console.ReadLine();

            string inputTwo = "MMRMMRMRRM";

            char[] instructionsTwo = inputTwo.ToCharArray();

            ExAshTwelveRover.Explore(instructionsTwo);

            ExAshTwelveRover.ShowLocation();


        }

        public static void ShowMenu()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("**************Tupiniquin Robot**************");
            Console.WriteLine("********************************************");

            Console.WriteLine($"Type the initial position of the rover: ");
        }
    }
}
