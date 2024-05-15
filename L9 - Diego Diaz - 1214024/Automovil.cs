using System.Reflection.Metadata;

class Automovil
{
    string saludo = "Hola Auto";
    int modelo = 2019;
    double precio = 10000.00;
    string marca = "";
    bool disponible = false;
    double tipoCambioDolar = 7.50;
    double descuentoAplicado = 0.00;


    public Automovil(string NuevoSaludo)
    {
        saludo = NuevoSaludo;
    }

    public string ObtenerSaludo()
    {
        return saludo;
    }
    public int DefinirModelo()
    {
        return modelo;
    }

    public double AplicarDescuento()
    {
        double des;
        Console.WriteLine("Ingrese la cantidad, en quetzales, de su descuento:");
        des = Int32.Parse(Console.ReadLine());

        descuentoAplicado = des;

        return descuentoAplicado;
    }

    public double DefinirPrecio()
    {
        return precio - descuentoAplicado;
    }

    public string DefinirMarca()
    {
        return marca;
    }

    public double DefinirTipoCambio()
    {
        return tipoCambioDolar;
    }

    public bool CambiarDisponibilidad()
    {
        Console.WriteLine("Actualmente la disponibilidad es 'false', desea cambiralo? Responder con: 'Si' o 'No'");
        string cambiar;
        cambiar = Console.ReadLine();

        if(cambiar == "Si")
        {
            disponible = true;
            return true;
        }

        return false;
    }

    string d = "Disponible";
    string nd = "No se encuentra disponible actualmente";

    public string MostrarDisponibilidad()
    {
        if(disponible == true)
        {
            return d;
        }

        return nd;
    }

    public double PrecioDolares()
    {
        return DefinirPrecio() / 7.50;
    }

    public string MostrarInformacion()
    {
        return $"Marca: {marca}. Modelo: {modelo}. Precio de Venta: Q.{DefinirPrecio()}. Precio en dolares: ${PrecioDolares()}. Disponibilidad: {MostrarDisponibilidad()}";
    }
}