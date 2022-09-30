namespace CountDivLibrary
{
    public class Algoritm
    {
        public int CountDivisible(int A, int B, int K)
        {
            int[] result = new int[(B+1)-A];
            int index = 0;

            for (int i = A; i < B + 1; i++)
            {
                index = i % K == 0 ? index +1 : index + 0;
            }
            return index; 
        }
    }
}