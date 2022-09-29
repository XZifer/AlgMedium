using System.Linq;

namespace MissingIntegerLibrary
{
    public class Algoritmo
    {
        public int MissingInt(int[] A)
        {
            int[] B;
            int index;
            A.Distinct().ToArray();
            B = A.OrderBy(x => x).ToArray();
            index = Array.IndexOf(B, 1);
            if (index == -1)
            {
                return 1;
            }
            for (int i = index; i < B.Length; i++)
            {
                if (i == B.Length - 1 
                 || B[i + 1] - B[i] > 1)
                {
                    return B[i] + 1;
                }
            }
            return 0;
        }
    }
}