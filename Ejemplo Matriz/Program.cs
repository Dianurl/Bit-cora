class Program
{
    static void Main(string[] args)
    {
        OperacionesMatrices operacionesMatrices = new OperacionesMatrices();
        char opcion = 'a';

        operacionesMatrices.CrearMatriz();
        operacionesMatrices.IngresarDatosMatriz();

        while (opcion != 'd')
        {
            Console.WriteLine("Menú opciones");
            Console.WriteLine(" a) Multiplicación de matriz por escalar");
            Console.WriteLine(" b) Devolver todas las posisciones por fila de un elemento menor");
            Console.WriteLine(" c) Encontrar vectores pares");
            Console.WriteLine(" d) Salir");
            Console.WriteLine("Ingrese opción: ");
            opcion = Console.ReadLine()[0];

            switch (opcion)
            {
                case 'a':
                    Console.WriteLine("Ingrese un escalar");
                    int escalar = Int32.Parse(Console.ReadLine() + "");
                    int[,] matrizesca = operacionesMatrices.MultiplicaciónMatrizEscalar(escalar);
                    operacionesMatrices.ImprimirMatriz(matrizesca);
                    break;
                
                case 'b':
                    int numeroencontrar;
                    Console.WriteLine("Ingrese el numero que desea buscar");
                    numeroencontrar = Int32.Parse(Console.ReadLine() + "");
                    int[,] matrixfind = operacionesMatrices.ValorMenor(numeroencontrar);
                    operacionesMatrices.ImprimirMatriz(matrixfind);
                    break;

                case 'c':
                    int[,] matrixvec = operacionesMatrices.Vectorpares();
                    operacionesMatrices.ImprimirMatriz(matrixvec);
                    break;
                
                case 'd':
                    Console.WriteLine("Se ha salido exitosamente");
                    break;
            }
        }
    }
}