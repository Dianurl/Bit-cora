using System.Data;

class Program
{
    static void Main(string[]args)
    {
        int NFibonacci;
        bool conversionAint = false;
        bool nPositivo = false;

        do
        {
            Console.WriteLine("Ingrese un número mayor a 0");
            conversionAint = int.TryParse(Console.ReadLine(), out NFibonacci);
            if(conversionAint)
            {
                if(NFibonacci>0)
                {
                    nPositivo = true;
                }
            }
        }
        while (!conversionAint || !nPositivo);
    
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("Ejercicio #2:");
        int A = 0;
        int B = 1;
        int C = 0;
        int i = 2;
        int resultado;
        int n;
        bool nn = false;

            Console.WriteLine("Escribir un valor n:");
            nn = int.TryParse(Console.ReadLine(), out n);
            if(nn)
            {
                if(n > 0)
                {
                    resultado = A;
                    Console.WriteLine(" ");
                    Console.WriteLine(resultado);

                    if (n > 1)
                    {
                        resultado = B;
                        Console.WriteLine(resultado);

                            while(i < n)
                            {
                                C = A + B;
                                resultado = C;
                                A = B;
                                B = C;
                                i = i +1;
                                Console.WriteLine(resultado);
                            }
                    }
                }
            }
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("Tarea #1: Aplicacion de Consola");

        int x;
        int a;
        int N;
        Console.WriteLine("Ingrese un numero N:");
        N = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero x:");
        x = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero a:");
        a = Int32.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        if(N >0)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Parte a):");
            for(int S=1; S < N+1; S=S+1)
            {
                Console.WriteLine($"{1/S}");
            }
            if(N > 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Parte b):");
                for(int S=1; S < N+1; S=S+1)
                {
                    Console.WriteLine($"{1/2^S}");
                }
                 if(N > 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Parte c):");
                    for(int k=0; k < N+1; k=k+1)
                    {
                        Console.WriteLine($"{x^k *a^N-k}");
                    }
                }
            }
        }
    }
}