namespace LeftOrRight_
{
    public class Move
    {
        public static IMovement TryParseProgramMove(string query )
        {
            if (query.Contains('?'))
            {
                return  new IlegalMove(query);
               
            }
            else
            {
                
                return new LegebleMove(query);
            }

        }
    }
}
