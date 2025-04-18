
namespace Tupiniquin_Robot
{
    
       public class Robot
        {
            public int PositionX;
            public int PositionY;
            public string PointingPosition;

            public void Explore(char[] instructions)
            {
                for (int counter = 0; counter < instructions.Length; counter++)
                {
                    char instruction = instructions[counter];

                    if (instruction == 'L')
                        TurnLeft();

                    else if (instruction == 'R')
                        TurnRight();

                    else if (instruction == 'M')
                        Move();
                }
            }

            public void TurnLeft()
            {
                if (PointingPosition == "N")
                    PointingPosition = "W";

                else if (PointingPosition == "W")
                    PointingPosition = "S";

                else if (PointingPosition == "S")
                    PointingPosition = "E";

                else if (PointingPosition == "E")
                    PointingPosition = "N";
            }

            public void TurnRight()
            {
                if (PointingPosition == "N")
                    PointingPosition = "E";

                else if (PointingPosition == "E")
                    PointingPosition = "S";

                else if (PointingPosition == "S")
                    PointingPosition = "W";

                else if (PointingPosition == "W")
                    PointingPosition = "N";
            }

            public void Move()
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

            public void ShowLocation()
            {
                Console.WriteLine();
                Console.WriteLine("****************New Position****************");
                Console.WriteLine($"Position X: {PositionX}");
                Console.WriteLine($"Position Y: {PositionY}");
                Console.WriteLine($"Point Position: {PointingPosition}");
                Console.ReadLine();
            }
             

          



        }
    
}
