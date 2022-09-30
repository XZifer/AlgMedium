using System.Xml.Schema;

namespace CountDivLibrary
{
    public class Algoritm
    {
        public int CountDivisible(int A, int B, int K)
        {
            return B/K - A/K + (A%K == 0 ? 1 : 0);
        }
    }
}