
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class OperacionesMatrices
{
    public int[,] matriz = new int[0,0];

    public OperacionesMatrices()
    {
    }

    public void CrearMatriz()
    {
        int cantidadFilas = 0;
        int cantidadCols = 0;

        Console.WriteLine("Ingrese la cantidad de filas de la matriz");
        cantidadFilas = Int32.Parse(Console.ReadLine() + "");
        Console.WriteLine("Ingrese la cantidad de columnas de la matriz");
        cantidadCols = Int32.Parse(Console.ReadLine() + "");

        matriz = new int[cantidadFilas,cantidadCols];
    }

    public void IngresarDatosMatriz()
    {
        //Ejemplos con dos for (hay más formas)
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                Console.WriteLine($"Ingrese valor para la posicion [{fila}][{columna}]");
                matriz[fila,columna] = Int32.Parse(Console.ReadLine() + "");
            }
        }
    }  

    public int[,] MultiplicaciónMatrizEscalar(int escalar)
    {
        int[,] matrizMultiplicada  = new int[matriz.GetLength(0), matriz.GetLength(1)];

        //Ejemplos con dos for (hay más formas)
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                matrizMultiplicada[fila,columna] = matriz[fila,columna] * escalar;
            }
        }

        return matrizMultiplicada;
    }

    public void ImprimirMatriz(int[,] matriz)
    {
        Console.WriteLine("La matriz es: ");
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                Console.Write(matriz[fila,columna] + "\t");
            }
            Console.WriteLine();
        }
    }


    public int[,] ValorMenor(int numeroencontrar)
    {
        int x = matriz.GetLength(0);
        int[,] matrizvalor = new int[x, 2];

        for(int fila = 0; fila < x; fila++)
        {
            int cont = 0;
            for(int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                if(matriz[fila,columna] < numeroencontrar)
                {
                    cont++;
                }
            }
            matrizvalor[fila,0] = fila;
            matrizvalor[fila,1] = cont;
        }
        return matrizvalor;
    }

    public int[,] Vectorpares()
    {
        int a = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if(matriz[i,j] % 2 == 0)
                {
                    a++;
                }
            }
        }

        int[,] vec = new int[1, a];
        int par = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if(matriz[i,j] % 2 == 0)
                {
                    vec[0, par] = matriz[i,j];
                    par++;
                }
            }
        }

        return vec;
    }
}