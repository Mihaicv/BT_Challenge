
using System.Linq;

namespace QaChallenge
{
    public class IndexSearch
    {

        public int Return_smallest_index(int[] array)
        {
            if (array.Length == 0) return 0;

            for (int i = 0; i < array.Length; i++)
            {
                int sumLeft = (array[0..i]).Sum();
                int sumRight = (array[(i + 1)..]).Sum();
                if (sumLeft == sumRight) return i;
            }
            return -1;
        }
    }
}