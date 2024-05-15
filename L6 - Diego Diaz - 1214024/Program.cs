class Program
{
static void Main(string[] args)
{
Console.WriteLine("Ejercicio #1:");
Console.WriteLine(" ");
int numeroMes;
string entradaMes;
string mesCadena;
Console.WriteLine("Ingrese un numero del 1 al 12 para mostrar el nombre del mes");
entradaMes = Console.ReadLine();
if(int.TryParse(entradaMes, out numeroMes))
{
Console.WriteLine($"Se convirtio '{entradaMes}' a '{numeroMes}'");
}
else
{
Console.WriteLine("Error: Ingresar un numero del 1 al 12");
}
Console.WriteLine(numeroMes);
switch(numeroMes)
{
case 1:
mesCadena = "Enero";
break;
case 2:
mesCadena = "Febrero";
break;
case 3:
mesCadena = "Marzo";
break;
case 4:
mesCadena = "Abril";
break;
case 5:
mesCadena = "Mayo";
break;
case 6:
mesCadena = "Junio";
break;
case 7:
mesCadena = "Julio";
break;
case 8:
mesCadena = "Agosto";
break;
case 9:
mesCadena = "Septiembre";
break;
case 10:
mesCadena = "Octubre";
break;
case 11:
mesCadena = "Noviembre";
break;
case 12:
mesCadena = "Diciembre";
break;
default:
mesCadena = "";
Console.WriteLine("Error: Debe ingresar un numero del 1 al 12");
break;
}
Console.WriteLine($"Mes: '{mesCadena}'");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Ejercicio #2:");
Console.WriteLine(" ");
Console.WriteLine("Recordatorio: Los numero deben ser mayores a 0");
double numero1;
double numero2;
double numero3;
Console.WriteLine("Ingrese un numero");
numero1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un segundo numero");
numero2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un tercer numero");
numero3 = Int32.Parse(Console.ReadLine());
if(numero1 > numero2)
{
if(numero1 > numero3)
{
if(numero2 > numero3)
{
Console.WriteLine($"El orden es: '{numero1}'>'{numero2}'> '{numero3}'");
}
else
{
if(numero3 > numero2)
{
Console.WriteLine($"El orden es: '{numero1}'> '{numero3}'> '{numero2}'");
}
}
}
else
{
if(numero1 == numero3)
{
Console.WriteLine($"El orden es: '{numero1}'= '{numero3}' y los dos son > '{numero2}'");
}
else
{
if(numero1 < numero3);
{
Console.WriteLine($"El orden es: '{numero3}'> '{numero1}'> '{numero2}'");
}
}
}
}
else
{
if(numero1 == numero2)
{
if(numero1 > numero3)
{
Console.WriteLine($"El orden es: '{numero1}'= '{numero2}'y los dos son > '{numero3}'");
}
else
{
if(numero1 == numero3)
{
Console.WriteLine($"El orden es: '{numero1}'= '{numero2}'= '{numero3}'");
}
else
{
if(numero1 < numero3)
{
Console.WriteLine($"El orden es: '{numero1}'= '{numero2}' y los dos son < '{numero3}'");
}
}
}
}
else
{
if(numero2 > numero3)
{
if(numero3 > numero1)
{
Console.WriteLine($"El orden es: '{numero2}'> '{numero3}' > '{numero1}'");
}
else
{
if(numero2 < numero1)
{
Console.WriteLine($"El orden es: '{numero1}'> '{numero2}'> '{numero3}'");
}
}
}
else
{
if(numero2 == numero3)
{
if(numero2 > numero1)
{
Console.WriteLine($"El orden es: '{numero2}'= '{numero3}' y los dos son > '{numero1}'");
}
else
{
if(numero2 < numero1)
{
Console.WriteLine($"El orden es: '{numero2}'= '{numero3}' y los dos son < '{numero1}'");
}
}
}
}
if(numero2 > numero1)
{
if(numero3 < numero1)
{
Console.WriteLine($"El orden es: '{numero2}'> '{numero1}' > '{numero3}'");
}
}
if(numero3 > numero2)
{
if(numero2 > numero1)
{
Console.WriteLine($"El orden es: '{numero3}'> '{numero2}' > '{numero1}'");
}
}
}
}
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Ejercicio #3: Tarea");
Console.WriteLine(" ");
Console.WriteLine("Escribir los meses con mayuscula en la primera letra");
double nAño;
string nMes;
string mCadena;
double nDia;
Console.WriteLine("¿Cuál es el año de su nacimiento?");
nAño = Int32.Parse(Console.ReadLine());
Console.WriteLine("¿Cuál es el mes de su nacimiento? ");
nMes = Console.ReadLine();
Console.WriteLine("¿Cuál es el día de su nacimiento?");
nDia = Int32.Parse(Console.ReadLine());
if(nMes == "Enero")
{
switch(nDia)
{
case 1:
mCadena = "Capricornio";
break;
case 2:
mCadena = "Capricornio";
break;
case 3:
mCadena = "Capricornio";
break;
case 4:
mCadena = "Capricornio";
break;
case 5:
mCadena = "Capricornio";
break;
case 6:
mCadena = "Capricornio";
break;
case 7:
mCadena = "Capricornio";
break;
case 8:
mCadena = "Capricornio";
break;
case 9:
mCadena = "Capricornio";
break;
case 10:
mCadena = "Capricornio";
break;
case 11:
mCadena = "Capricornio";
break;
case 12:
mCadena = "Capricornio";
break;
case 13:
mCadena = "Capricornio";
break;
case 14:
mCadena = "Capricornio";
break;
case 15:
mCadena = "Capricornio";
break;
case 16:
mCadena = "Capricornio";
break;
case 17:
mCadena = "Capricornio";
break;
case 18:
mCadena = "Capricornio";
break;
case 19:
mCadena = "Capricornio";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Enero")
{
switch(nDia)
{
case 20:
mCadena = "Acuario";
break;
case 21:
mCadena = "Acuario";
break;
case 22:
mCadena = "Acuario";
break;
case 23:
mCadena = "Acuario";
break;
case 24:
mCadena = "Acuario";
break;
case 25:
mCadena = "Acuario";
break;
case 26:
mCadena = "Acuario";
break;
case 27:
mCadena = "Acuario";
break;
case 28:
mCadena = "Acuario";
break;
case 29:
mCadena = "Acuario";
break;
case 30:
mCadena = "Acuario";
break;
case 31:
mCadena = "Acuario";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Febrero")
{
switch(nDia)
{
case 1:
mCadena = "Acuario";
break;
case 2:
mCadena = "Acuario";
break;
case 3:
mCadena = "Acuario";
break;
case 4:
mCadena = "Acuario";
break;
case 5:
mCadena = "Acuario";
break;
case 6:
mCadena = "Acuario";
break;
case 7:
mCadena = "Acuario";
break;
case 8:
mCadena = "Acuario";
break;
case 9:
mCadena = "Acuario";
break;
case 10:
mCadena = "Acuario";
break;
case 11:
mCadena = "Acuario";
break;
case 12:
mCadena = "Acuario";
break;
case 13:
mCadena = "Acuario";
break;
case 14:
mCadena = "Acuario";
break;
case 15:
mCadena = "Acuario";
break;
case 16:
mCadena = "Acuario";
break;
case 17:
mCadena = "Acuario";
break;
case 18:
mCadena = "Acuario";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Febrero")
{
switch(nDia)
{
case 19:
mCadena = "Piscis";
break;
case 20:
mCadena = "Piscis";
break;
case 21:
mCadena = "Piscis";
break;
case 22:
mCadena = "Piscis";
break;
case 23:
mCadena = "Piscis";
break;
case 24:
mCadena = "Piscis";
break;
case 25:
mCadena = "Piscis";
break;
case 26:
mCadena = "Piscis";
break;
case 27:
mCadena = "Piscis";
break;
case 28:
mCadena = "Piscis";
break;
case 29:
mCadena = "Piscis";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Marzo")
{
switch(nDia)
{
case 1:
mCadena = "Piscis";
break;
case 2:
mCadena = "Piscis";
break;
case 3:
mCadena = "Piscis";
break;
case 4:
mCadena = "Piscis";
break;
case 5:
mCadena = "Piscis";
break;
case 6:
mCadena = "Piscis";
break;
case 7:
mCadena = "Piscis";
break;
case 8:
mCadena = "Piscis";
break;
case 9:
mCadena = "Piscis";
break;
case 10:
mCadena = "Piscis";
break;
case 11:
mCadena = "Piscis";
break;
case 12:
mCadena = "Piscis";
break;
case 13:
mCadena = "Piscis";
break;
case 14:
mCadena = "Piscis";
break;
case 15:
mCadena = "Piscis";
break;
case 16:
mCadena = "Piscis";
break;
case 17:
mCadena = "Piscis";
break;
case 18:
mCadena = "Piscis";
break;
case 19:
mCadena = "Piscis";
break;
case 20:
mCadena = "Piscis";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Marzo")
{
switch(nDia)
{
case 21:
mCadena = "Aries";
break;
case 22:
mCadena = "Aries";
break;
case 23:
mCadena = "Aries";
break;
case 24:
mCadena = "Aries";
break;
case 25:
mCadena = "Aries";
break;
case 26:
mCadena = "Aries";
break;
case 27:
mCadena = "Aries";
break;
case 28:
mCadena = "Aries";
break;
case 29:
mCadena = "Aries";
break;
case 30:
mCadena = "Aries";
break;
case 31:
mCadena = "Aries";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Abril")
{
switch(nDia)
{
case 1:
mCadena = "Aries";
break;
case 2:
mCadena = "Aries";
break;
case 3:
mCadena = "Aries";
break;
case 4:
mCadena = "Aries";
break;
case 5:
mCadena = "Aries";
break;
case 6:
mCadena = "Aries";
break;
case 7:
mCadena = "Aries";
break;
case 8:
mCadena = "Aries";
break;
case 9:
mCadena = "Aries";
break;
case 10:
mCadena = "Aries";
break;
case 11:
mCadena = "Aries";
break;
case 12:
mCadena = "Aries";
break;
case 13:
mCadena = "Aries";
break;
case 14:
mCadena = "Aries";
break;
case 15:
mCadena = "Aries";
break;
case 16:
mCadena = "Aries";
break;
case 17:
mCadena = "Aries";
break;
case 18:
mCadena = "Aries";
break;
case 19:
mCadena = "Aries";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Abril")
{
switch(nDia)
{
case 20:
mCadena = "Tauro";
break;
case 21:
mCadena = "Tauro";
break;
case 22:
mCadena = "Tauro";
break;
case 23:
mCadena = "Tauro";
break;
case 24:
mCadena = "Tauro";
break;
case 25:
mCadena = "Tauro";
break;
case 26:
mCadena = "Tauro";
break;
case 27:
mCadena = "Tauro";
break;
case 28:
mCadena = "Tauro";
break;
case 29:
mCadena = "Tauro";
break;
case 30:
mCadena = "Tauro";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Mayo")
{
switch(nDia)
{
case 1:
mCadena = "Tauro";
break;
case 2:
mCadena = "Tauro";
break;
case 3:
mCadena = "Tauro";
break;
case 4:
mCadena = "Tauro";
break;
case 5:
mCadena = "Tauro";
break;
case 6:
mCadena = "Tauro";
break;
case 7:
mCadena = "Tauro";
break;
case 8:
mCadena = "Tauro";
break;
case 9:
mCadena = "Tauro";
break;
case 10:
mCadena = "Tauro";
break;
case 11:
mCadena = "Tauro";
break;
case 12:
mCadena = "Tauro";
break;
case 13:
mCadena = "Tauro";
break;
case 14:
mCadena = "Tauro";
break;
case 15:
mCadena = "Tauro";
break;
case 16:
mCadena = "Tauro";
break;
case 17:
mCadena = "Tauro";
break;
case 18:
mCadena = "Tauro";
break;
case 19:
mCadena = "Tauro";
break;
case 20:
mCadena = "Tauro";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Mayo")
{
switch(nDia)
{
case 21:
mCadena = "Geminis";
break;
case 22:
mCadena = "Geminis";
break;
case 23:
mCadena = "Geminis";
break;
case 24:
mCadena = "Geminis";
break;
case 25:
mCadena = "Geminis";
break;
case 26:
mCadena = "Geminis";
break;
case 27:
mCadena = "Geminis";
break;
case 28:
mCadena = "Geminis";
break;
case 29:
mCadena = "Geminis";
break;
case 30:
mCadena = "Geminis";
break;
case 31:
mCadena = "Geminis";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Junio")
{
switch(nDia)
{
case 1:
mCadena = "Geminis";
break;
case 2:
mCadena = "Geminis";
break;
case 3:
mCadena = "Geminis";
break;
case 4:
mCadena = "Geminis";
break;
case 5:
mCadena = "Geminis";
break;
case 6:
mCadena = "Geminis";
break;
case 7:
mCadena = "Geminis";
break;
case 8:
mCadena = "Geminis";
break;
case 9:
mCadena = "Geminis";
break;
case 10:
mCadena = "Geminis";
break;
case 11:
mCadena = "Geminis";
break;
case 12:
mCadena = "Geminis";
break;
case 13:
mCadena = "Geminis";
break;
case 14:
mCadena = "Geminis";
break;
case 15:
mCadena = "Geminis";
break;
case 16:
mCadena = "Geminis";
break;
case 17:
mCadena = "Geminis";
break;
case 18:
mCadena = "Geminis";
break;
case 19:
mCadena = "Geminis";
break;
case 20:
mCadena = "Geminis";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Junio")
{
switch(nDia)
{
case 21:
mCadena = "Cancer";
break;
case 22:
mCadena = "Cancer";
break;
case 23:
mCadena = "Cancer";
break;
case 24:
mCadena = "Cancer";
break;
case 25:
mCadena = "Cancer";
break;
case 26:
mCadena = "Cancer";
break;
case 27:
mCadena = "Cancer";
break;
case 28:
mCadena = "Cancer";
break;
case 29:
mCadena = "Cancer";
break;
case 30:
mCadena = "Cancer";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Julio")
{
switch(nDia)
{
case 1:
mCadena = "Cancer";
break;
case 2:
mCadena = "Cancer";
break;
case 3:
mCadena = "Cancer";
break;
case 4:
mCadena = "Cancer";
break;
case 5:
mCadena = "Cancer";
break;
case 6:
mCadena = "Cancer";
break;
case 7:
mCadena = "Cancer";
break;
case 8:
mCadena = "Cancer";
break;
case 9:
mCadena = "Cancer";
break;
case 10:
mCadena = "Cancer";
break;
case 11:
mCadena = "Cancer";
break;
case 12:
mCadena = "Cancer";
break;
case 13:
mCadena = "Cancer";
break;
case 14:
mCadena = "Cancer";
break;
case 15:
mCadena = "Cancer";
break;
case 16:
mCadena = "Cancer";
break;
case 17:
mCadena = "Cancer";
break;
case 18:
mCadena = "Cancer";
break;
case 19:
mCadena = "Cancer";
break;
case 20:
mCadena = "Cancer";
break;
case 21:
mCadena = "Cancer";
break;
case 22:
mCadena = "Cancer";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Julio")
{
switch(nDia)
{
case 23:
mCadena = "Leo";
break;
case 24:
mCadena = "Leo";
break;
case 25:
mCadena = "Leo";
break;
case 26:
mCadena = "Leo";
break;
case 27:
mCadena = "Leo";
break;
case 28:
mCadena = "Leo";
break;
case 29:
mCadena = "Leo";
break;
case 30:
mCadena = "Leo";
break;
case 31:
mCadena = "Leo";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Agosto")
{
switch(nDia)
{
case 1:
mCadena = "Leo";
break;
case 2:
mCadena = "Leo";
break;
case 3:
mCadena = "Leo";
break;
case 4:
mCadena = "Leo";
break;
case 5:
mCadena = "Leo";
break;
case 6:
mCadena = "Leo";
break;
case 7:
mCadena = "Leo";
break;
case 8:
mCadena = "Leo";
break;
case 9:
mCadena = "Leo";
break;
case 10:
mCadena = "Leo";
break;
case 11:
mCadena = "Leo";
break;
case 12:
mCadena = "Leo";
break;
case 13:
mCadena = "Leo";
break;
case 14:
mCadena = "Leo";
break;
case 15:
mCadena = "Leo";
break;
case 16:
mCadena = "Leo";
break;
case 17:
mCadena = "Leo";
break;
case 18:
mCadena = "Leo";
break;
case 19:
mCadena = "Leo";
break;
case 20:
mCadena = "Leo";
break;
case 21:
mCadena = "Leo";
break;
case 22:
mCadena = "Leo";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Agosto")
{
switch(nDia)
{
case 23:
mCadena = "Virgo";
break;
case 24:
mCadena = "Virgo";
break;
case 25:
mCadena = "Virgo";
break;
case 26:
mCadena = "Virgo";
break;
case 27:
mCadena = "Virgo";
break;
case 28:
mCadena = "Virgo";
break;
case 29:
mCadena = "Virgo";
break;
case 30:
mCadena = "Virgo";
break;
case 31:
mCadena = "Virgo";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Septiembre")
{
switch(nDia)
{
case 1:
mCadena = "Virgo";
break;
case 2:
mCadena = "Virgo";
break;
case 3:
mCadena = "Virgo";
break;
case 4:
mCadena = "Virgo";
break;
case 5:
mCadena = "Virgo";
break;
case 6:
mCadena = "Virgo";
break;
case 7:
mCadena = "Virgo";
break;
case 8:
mCadena = "Virgo";
break;
case 9:
mCadena = "Virgo";
break;
case 10:
mCadena = "Virgo";
break;
case 11:
mCadena = "Virgo";
break;
case 12:
mCadena = "Virgo";
break;
case 13:
mCadena = "Virgo";
break;
case 14:
mCadena = "Virgo";
break;
case 15:
mCadena = "Virgo";
break;
case 16:
mCadena = "Virgo";
break;
case 17:
mCadena = "Virgo";
break;
case 18:
mCadena = "Virgo";
break;
case 19:
mCadena = "Virgo";
break;
case 20:
mCadena = "Virgo";
break;
case 21:
mCadena = "Virgo";
break;
case 22:
mCadena = "Virgo";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Septiembre")
{
switch(nDia)
{
case 23:
mCadena = "Libra";
break;
case 24:
mCadena = "Libra";
break;
case 25:
mCadena = "Libra";
break;
case 26:
mCadena = "Libra";
break;
case 27:
mCadena = "Libra";
break;
case 28:
mCadena = "Libra";
break;
case 29:
mCadena = "Libra";
break;
case 30:
mCadena = "Libra";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Octubre")
{
switch(nDia)
{
case 1:
mCadena = "Libra";
break;
case 2:
mCadena = "Libra";
break;
case 3:
mCadena = "Libra";
break;
case 4:
mCadena = "Libra";
break;
case 5:
mCadena = "Libra";
break;
case 6:
mCadena = "Libra";
break;
case 7:
mCadena = "Libra";
break;
case 8:
mCadena = "Libra";
break;
case 9:
mCadena = "Libra";
break;
case 10:
mCadena = "Libra";
break;
case 11:
mCadena = "Libra";
break;
case 12:
mCadena = "Libra";
break;
case 13:
mCadena = "Libra";
break;
case 14:
mCadena = "Libra";
break;
case 15:
mCadena = "Libra";
break;
case 16:
mCadena = "Libra";
break;
case 17:
mCadena = "Libra";
break;
case 18:
mCadena = "Libra";
break;
case 19:
mCadena = "Libra";
break;
case 20:
mCadena = "Libra";
break;
case 21:
mCadena = "Libra";
break;
case 22:
mCadena = "Libra";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Octubre")
{
switch(nDia)
{
case 23:
mCadena = "Scorpio";
break;
case 24:
mCadena = "Scorpio";
break;
case 25:
mCadena = "Scorpio";
break;
case 26:
mCadena = "Scorpio";
break;
case 27:
mCadena = "Scorpio";
break;
case 28:
mCadena = "Scorpio";
break;
case 29:
mCadena = "Scorpio";
break;
case 30:
mCadena = "Scorpio";
break;
case 31:
mCadena = "Scorpio";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Noviembre")
{
switch(nDia)
{
case 1:
mCadena = "Scorpio";
break;
case 2:
mCadena = "Scorpio";
break;
case 3:
mCadena = "Scorpio";
break;
case 4:
mCadena = "Scorpio";
break;
case 5:
mCadena = "Scorpio";
break;
case 6:
mCadena = "Scorpio";
break;
case 7:
mCadena = "Scorpio";
break;
case 8:
mCadena = "Scorpio";
break;
case 9:
mCadena = "Scorpio";
break;
case 10:
mCadena = "Scorpio";
break;
case 11:
mCadena = "Scorpio";
break;
case 12:
mCadena = "Scorpio";
break;
case 13:
mCadena = "Scorpio";
break;
case 14:
mCadena = "Scorpio";
break;
case 15:
mCadena = "Scorpio";
break;
case 16:
mCadena = "Scorpio";
break;
case 17:
mCadena = "Scorpio";
break;
case 18:
mCadena = "Scorpio";
break;
case 19:
mCadena = "Scorpio";
break;
case 20:
mCadena = "Scorpio";
break;
case 21:
mCadena = "Scorpio";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Noviembre")
{
switch(nDia)
{
case 22:
mCadena = "Sagitario";
break;
case 23:
mCadena = "Sagitario";
break;
case 24:
mCadena = "Sagitario";
break;
case 25:
mCadena = "Sagitario";
break;
case 26:
mCadena = "Sagitario";
break;
case 27:
mCadena = "Sagitario";
break;
case 28:
mCadena = "Sagitario";
break;
case 29:
mCadena = "Sagitario";
break;
case 30:
mCadena = "Sagitario";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Diciembre")
{
switch(nDia)
{
case 1:
mCadena = "Sagitario";
break;
case 2:
mCadena = "Sagitario";
break;
case 3:
mCadena = "Sagitario";
break;
case 4:
mCadena = "Sagitario";
break;
case 5:
mCadena = "Sagitario";
break;
case 6:
mCadena = "Sagitario";
break;
case 7:
mCadena = "Sagitario";
break;
case 8:
mCadena = "Sagitario";
break;
case 9:
mCadena = "Sagitario";
break;
case 10:
mCadena = "Sagitario";
break;
case 11:
mCadena = "Sagitario";
break;
case 12:
mCadena = "Sagitario";
break;
case 13:
mCadena = "Sagitario";
break;
case 14:
mCadena = "Sagitario";
break;
case 15:
mCadena = "Sagitario";
break;
case 16:
mCadena = "Sagitario";
break;
case 17:
mCadena = "Sagitario";
break;
case 18:
mCadena = "Sagitario";
break;
case 19:
mCadena = "Sagitario";
break;
case 20:
mCadena = "Sagitario";
break;
case 21:
mCadena = "Sagitario";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
if(nMes == "Diciembre")
{
switch(nDia)
{
case 22:
mCadena = "Capricornio";
break;
case 23:
mCadena = "Capricornio";
break;
case 24:
mCadena = "Capricornio";
break;
case 25:
mCadena = "Capricornio";
break;
case 26:
mCadena = "Capricornio";
break;
case 27:
mCadena = "Capricornio";
break;
case 28:
mCadena = "Capricornio";
break;
case 29:
mCadena = "Capricornio";
break;
case 30:
mCadena = "Capricornio";
break;
case 31:
mCadena = "Capricornio";
break;
default:
mCadena = "";
break;
}
Console.WriteLine($"Su Signo del Zodiaco es: '{mCadena}'");
}
}
}