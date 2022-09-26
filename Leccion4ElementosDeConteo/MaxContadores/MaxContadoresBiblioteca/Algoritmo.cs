namespace MaxContadoresBiblioteca
{
    public class Algoritmo
    {
        //N = Numero de Contadores
        public int[] ContadorMaximo(int N, int[] A)
        {
            #region version1
            //int[] Contador = new int[N];
            //foreach (int op in A)
            //{
            //    for (int i = 0; i < Contador.Length; i++)
            //    {
            //        if (op == i +1 )
            //        {
            //            Contador[i]++;
            //            i = Contador.Length;
            //        }
            //        else if (op > N)
            //        {
            //            int max = Contador.Max();
            //            for (int c = 0; c < Contador.Length; c++)
            //            {
            //                Contador[c] = max;
            //            }
            //            i = Contador.Length;
            //        }
            //    }
            //}
            //return Contador;
            #endregion
            int[] result = new int[N];
            int maxCounter = 0;
            int groupMaxCounter = 0;

            for (int x = 0; x < A.Length; x++)
            {
                if (A[x] == N + 1)
                {
                    groupMaxCounter = maxCounter;
                }
                else
                {
                    int index = A[x] - 1;
                    result[index] = result[index] < groupMaxCounter ? groupMaxCounter + 1 : ++result[index];
                    if (result[index] > maxCounter)
                    {
                        maxCounter = result[index];
                    }
                }

            }

            for (int y = 0; y < result.Length; y++)
                result[y] = result[y] < groupMaxCounter ? groupMaxCounter : result[y];

            return result;
        
        }
    }
}