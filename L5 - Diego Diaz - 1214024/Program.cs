class Program
{
static void Main(string[] args)
{
string nombre;
Console.WriteLine("Ingrese su nombre");
nombre = Console.ReadLine();
Console.WriteLine("Hola " + nombre);
Console.WriteLine(" ");
Console.WriteLine("Parte #2 - Ejercicio #1: Operaciones Aritmeticas");
int numero1;
int numero2;
Console.WriteLine("Ingrese un numero");
numero1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro numero");
numero2 = Int32.Parse(Console.ReadLine());
Console.WriteLine(" ");
int resultado = numero1 + numero2;
int resultado2 = numero1 - numero2;
int resultado3 = numero1 * numero2;
int resultado4 = numero1 / numero2;
int resultado5 = numero1 % numero2;
Console.WriteLine(+numero1+ "+" +numero2+ "=" + resultado);
Console.WriteLine(+numero1+ "-" +numero2+ "=" + resultado2);
Console.WriteLine(+numero1+ "*" +numero2+ "=" + resultado3);
Console.WriteLine(+numero1+ "/" +numero2+ "=" + resultado4);
Console.WriteLine(+numero1+ "%" +numero2+ "=" + resultado5);
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Ejercicio #2: Operaciones booleanas");
bool resultado6 = numero1 < numero2;
bool resultado7 = numero1 > numero2;
Console.WriteLine("El primer numero es menor que el segundo? - Respuesta:" + resultado6);
Console.WriteLine("El primer numero es mayor que el segundo? - Respuesta:" + resultado7);
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Ejercicio #3: Jerarquia de operaciones");
Console.WriteLine(" ");
int numero3;
int numero4;
int numero5;
Console.WriteLine("Ingrese un numero");
numero3 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un segundo numero");
numero4 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un tercer numero");
numero5 = Int32.Parse(Console.ReadLine());
Console.WriteLine(" ");
int resultado8 = (numero3 * numero4) + numero5;
int resultado9 = numero3 * (numero4 + numero5);
int resultado10 = numero3 / (numero4 * numero5);
int resultado11 = ((3*numero3) + (2*numero4)) / numero5^2;
Console.WriteLine(+numero3+ "*" +numero4+ "+" +numero5+ "= "
+resultado8);
Console.WriteLine(+numero3+ "* (" +numero4+ "+" +numero5+ ") = "
+resultado9);
Console.WriteLine(+numero3+ "/ (" +numero4+ "*" +numero5+ ") = "
+resultado10);
Console.WriteLine("3*" +numero3+ "+ 2*" +numero4+ "/" +numero5+ "^2 = " +resultado11);
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Ejercicio #4: Expresion cuadratica");
Console.WriteLine(" ");
double numero6;
double numero7;
double numero8;
Console.WriteLine("Antes de ingresar los numeros, se recomienda que no utilice el 0 como primer numero y que el descriminante sea mayor a 0");
Console.WriteLine("Ingrese un numero");
numero6 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un segundo numero");
numero7 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un tercer numero");
numero8 = Int32.Parse(Console.ReadLine());
double descriminante = ((numero7 * numero7)-4*numero6*numero8);
double resultado12=0;
double resultado13=0;
double raiz = Math.Sqrt(descriminante); // Sirve para sacar la raiz
if(numero6!=0 && descriminante>=0)
{
Console.WriteLine(" ");
resultado12 = (-numero7 + descriminante) / (2*numero6);
resultado13 = (-numero7 - descriminante) / (2*numero6);
Console.WriteLine("-" +numero7+ "+ √(" +numero7+ ")^2 -4*"
+numero6+ "*" +numero8+ "/ 2*" +numero6+ "= " +resultado12);
Console.WriteLine("-" +numero7+ "- √(" +numero7+ ")^2 -4*"
+numero6+ "*" +numero8+ "/ 2*" +numero6+ "= " +resultado13);
}
else
{
if(numero6==0)
{
Console.WriteLine("La operacion no se puede calcular debido a que el primer numero que ingreso es igual a 0");
}
if (descriminante<=0)
{
Console.WriteLine("La ecuacion no se puede calcular debido a que el decriminante da como resultado un numero menor a cero.");
}
}
}
}
