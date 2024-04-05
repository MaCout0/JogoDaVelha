namespace JogoDaVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
            MostrarTabuleiro(arr);
            Random random = new Random();
            int auxprincipal = 0;
            int numJogadas = 0;
            while (auxprincipal == 0)
            {
                int aux = 1;
                while (aux > 0)
                {
                    int aleatorio = random.Next(0, 8);

                    if (arr[aleatorio] == 'X')
                    {
                        continue;
                    }
                    else if (arr[aleatorio] == 'Y')
                    {
                        continue;
                    }
                    else
                    {
                        arr[aleatorio] = 'Y';
                        MostrarTabuleiro(arr);
                        numJogadas++;
                        aux--;
                    }
                }
                aux++;
                while (aux > 0)
                {
                    Console.WriteLine("Digito onde vai jogar o X:");
                    int alterarX = Convert.ToInt32(Console.ReadLine());
                    if (arr[alterarX] == 'Y')
                    {
                        continue;
                    }
                    else if (arr[alterarX] == 'X')
                    {
                        continue;
                    }
                    else
                    {
                        arr[alterarX] = 'X';
                        MostrarTabuleiro(arr);
                        numJogadas++;
                        aux--;
                    }
                    MostrarTabuleiro(arr);

                }
                if (numJogadas == arr.Length)
                {
                    auxprincipal = 2;
                }
                auxprincipal = ValidaVitoria(arr, auxprincipal);
            }
            if (auxprincipal == 1)
            {
                Console.Clear();
                Console.WriteLine("Você venceu");
            }
            if (auxprincipal == 2)
            {
                Console.Clear();
                Console.WriteLine("Deu velha");
            }
            Console.ReadLine();
        }

        private static int ValidaVitoria(char[] arr, int auxprincipal)
        {
            if ((arr[0] == arr[1]) && (arr[1] == arr[2]))
            {
                auxprincipal = 1;
            }
            else if ((arr[3] == arr[4]) && (arr[4] == arr[5]))
            {
                auxprincipal = 1;
            }
            else if ((arr[6] == arr[7]) && (arr[7] == arr[8]))
            {
                auxprincipal = 1;
            }
            else if ((arr[0] == arr[3]) && (arr[3] == arr[3]))
            {
                auxprincipal = 1;
            }
            else if ((arr[1] == arr[4]) && (arr[4] == arr[7]))
            {
                auxprincipal = 1;
            }
            else if ((arr[2] == arr[5]) && (arr[5] == arr[8]))
            {
                auxprincipal = 1;
            }
            else if ((arr[0] == arr[4]) && (arr[4] == arr[8]))
            {
                auxprincipal = 1;
            }
            else if ((arr[2] == arr[4]) && (arr[4] == arr[6]))
            {
                auxprincipal = 1;
            }

            return auxprincipal;
        }

        private static void MostrarTabuleiro(char[] arr)
        {
            Console.Clear();
            Console.WriteLine("Jogo da Velha: \n" +
                arr[0] + "|" + arr[1] + "|" + arr[2] + "\n" +
                "-------\n" +
                arr[3] + "|" + arr[4] + "|" + arr[5] + "\n" +
                 "-------\n" +
                arr[6] + "|" + arr[7] + "|" + arr[8] + "\n");
        }
    }
}
