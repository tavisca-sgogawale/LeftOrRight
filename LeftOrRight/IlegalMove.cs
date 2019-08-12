namespace LeftOrRight_
{
    public class IlegalMove : IMovement
    {
        private string _query;

       
        public int MaxDistance(string input)
        {
           
            int maxDistanceL = 0;
            int maxDistanceR = 0; 
            IMovement move = Move.TryParseProgramMove(input);
            maxDistanceL = move.MaxDistance(input.Replace('?','L'));
            maxDistanceR = move.MaxDistance(input.Replace('?', 'R'));
            return maxDistanceL>= maxDistanceR ? maxDistanceL: maxDistanceR;

        }
        public IlegalMove(string query)
        {
            this._query = query;
        }
    }
}
