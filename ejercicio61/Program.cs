namespace ejercicio61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N, X, Binario;
            Console.WriteLine("Ingrese un numero");
            N = double.Parse(Console.ReadLine());
            Binario = 0;
            X = 1;
            Console.WriteLine($"el numero {N} convertido a binario es");
            while (N >= 1)
            {
                if (N % 2 == 1)
                {
                    Binario = Binario + X;

                }
            N = Math.Truncate(N / 2);
            X = X * 10;
            }
            Console.WriteLine($"{Binario}");
        }
    }
}