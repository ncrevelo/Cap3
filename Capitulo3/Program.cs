class capitulo3
{
    static void Main()
    {
        double Factura;
        double descuento;
        int Cantidadproduc;
        double Precio;
        double PrecioBruto;

        double Ivacompra;
        Console.WriteLine("Ingrese el precio del producto");
        Precio = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad que va a llevar");
        Cantidadproduc = int.Parse(Console.ReadLine());

        Ivacompra = (Precio * Cantidadproduc) * 0.12;

        Console.WriteLine("El iva da un valor de: " + Ivacompra);
        PrecioBruto = (Precio * Cantidadproduc) + Ivacompra;
        if (PrecioBruto > 5000)
        {
            descuento = PrecioBruto * 0.05;
            Factura = PrecioBruto - descuento;
        }
        else
        {
            Factura = PrecioBruto;

        }
        Console.WriteLine("El precio de la factura corresponde:" + Factura);
    }
}
}

