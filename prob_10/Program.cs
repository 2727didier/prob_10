using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double montoConsumo = 120.00; // Cambia este valor al monto real del consumo
            double descuento;
            double impuesto;
            double subtotal;
            double importeTotal;
            if (montoConsumo <= 100.00)
            {
                descuento = montoConsumo * 0.10;
            }
            else
            {
                descuento = montoConsumo * 0.20;
            }
            subtotal = montoConsumo - descuento;
            impuesto = subtotal * 0.18;
            importeTotal = subtotal + impuesto;
            Console.WriteLine("Monto del descuento: " + descuento.ToString("C"));
            Console.WriteLine("Impuesto: " + impuesto.ToString("C"));
            Console.WriteLine("Subtotal: " + subtotal.ToString("C"));
            Console.WriteLine("Importe a pagar: " + importeTotal.ToString("C"));
        }
    }
}
