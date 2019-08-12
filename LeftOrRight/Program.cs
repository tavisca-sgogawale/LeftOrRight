using System;

namespace LeftOrRight_
{

    public class LeftOrRight
    {
        public int MaxDistance(string input)
        {
            int maxDistance = 0;
           IlegalMove mov;
            IMovement move = Move.TryParseProgramMove(input);
            maxDistance = move.MaxDistance(input);
            return maxDistance;

        }
        public static void Main(String[] args)
        {
            LeftOrRight leftOrRight = new LeftOrRight();
            String input = Console.ReadLine();
            do
            {
                Console.WriteLine(leftOrRight.MaxDistance(input));
                input = Console.ReadLine();
            } while (input != "-1");
        }

        
    }
}
