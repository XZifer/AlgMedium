using System.Linq;

namespace MissingIntegerLibrary
{
    public class Algoritmo
    {
        public int MissingInt(int[] A)
        {
            int[] B;
            int missing = 1;
            int index;
            A.Distinct().ToArray();
            B = A.OrderBy(x => x).ToArray();
            index = Array.IndexOf(B, 1);
            if (index != -1)
            {
                for (int i = index; i < B.Length; i++)
                {
                    if (i == B.Length -1)
                    {
                        missing = B[i] + 1;
                        return missing;
                    }
                    else if (B[i + 1] - B[i] > 1)
                    {
                        missing = B[i] + 1;
                        return missing;
                    }
                }
            }
            else
            {
                missing = 1;
            }
            return missing;
        }
    }
}