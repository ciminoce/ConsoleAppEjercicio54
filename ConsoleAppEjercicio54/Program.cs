using System;

namespace ConsoleAppEjercicio54
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Crear ciclo para controlar que el nro ingresado sea positivo y entero
            Console.Write("Ingrese un número entero y positivo:");
            var nroIngresado = int.Parse(Console.ReadLine());
            int nroOriginal = nroIngresado;
            int digitos = 0;
            while (nroIngresado>=1)
            {
                var division = nroIngresado / 10;
                nroIngresado = (int)Math.Truncate((double)division);
                digitos++;
            }


            Console.WriteLine($"{nroOriginal} tiene {digitos} dígitos");
            Console.ReadLine();
        }
    }
}
