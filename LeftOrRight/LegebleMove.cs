namespace LeftOrRight_
{
    public class LegebleMove : IMovement
    {
        private string _query;
        public int MaxDistance(string query)
        {
            int maxReach = 0;
            int position=0;
            var _instruction = query[0];
            foreach (char command in query)
            {
                _instruction = position == 0 ? command : _instruction;
                position += _instruction == command ? 1 : -1;
                maxReach = position < maxReach ? maxReach : position;
            }
            return maxReach;
        }
        public LegebleMove(string query)
        {
            this._query = query;

        }

    }
}
