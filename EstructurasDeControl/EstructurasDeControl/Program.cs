using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Ingrese el monto del préstamo: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal montoPrestamo) || montoPrestamo <= 0)
        {
            Console.WriteLine("Monto inválido.");
            return;
        }

        
        decimal tasaInteresAnual = 0.05m;
        int plazoAnios = 5;

        
        decimal interesAnual = montoPrestamo * tasaInteresAnual;
        decimal interesPrimerMes = interesAnual / 12;
        decimal interesTercerTrimestre = interesAnual / 4; 
        decimal interesTotal = interesAnual * plazoAnios;
        decimal totalPagado = montoPrestamo + interesTotal;

        Console.WriteLine($"\n--- Resultados ---");
        Console.WriteLine($"Interés pagado en un año: {interesAnual:C}");
        Console.WriteLine($"Interés pagado en el tercer trimestre del año: {interesTercerTrimestre:C}");
        Console.WriteLine($"Interés pagado en el primer mes: {interesPrimerMes:C}");
        Console.WriteLine($"Total pagado al final del préstamo (incluyendo intereses): {totalPagado:C}");
    }
}