namespace MaxContadoresBiblioteca
{
    public class Algoritmo
    {
        //N = Numero de Contadores
        public int[] ContadorMaximo(int N, int[] A)
        {
            int[] Contador = new int[N];
            foreach (int op in A)
            {
                for (int i = 0; i < Contador.Length; i++)
                {
                    if (op == i +1 )
                    {
                        Contador[i]++;
                        i = Contador.Length;
                    }
                    else if (op > N)
                    {
                        int max = Contador.Max();
                        for (int c = 0; c < Contador.Length; c++)
                        {
                            Contador[c] = max;
                        }
                        i = Contador.Length;
                    }
                }
            }
            return Contador;
        }
    }
}