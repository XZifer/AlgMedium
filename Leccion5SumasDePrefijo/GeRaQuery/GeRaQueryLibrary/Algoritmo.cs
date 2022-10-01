namespace GeRaQueryLibrary
{
    public class Algoritmo
    {
        public int[] FactMin(string S, int[] P, int[] Q)
        {
            int index = 0;
            string subs;
            int[] factsImp = new int[P.Length];
            for (int i = 0; i < P.Length; i++)
            {
                subs = S.Substring(P[i], Q[i] - P[i] +1);
                if (subs.Contains("A"))
                {
                    factsImp[index] = 1;
                }
                 else if (subs.Contains("C"))
                {
                    factsImp[index] = 2;
                }
                else if (subs.Contains("G"))
                {
                    factsImp[index] = 3;
                }
                else
                {
                    factsImp[index] = 4;
                }
                index++;
            }
            return factsImp;
        }
    }
}