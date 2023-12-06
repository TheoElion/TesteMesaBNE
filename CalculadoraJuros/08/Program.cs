using System;

class CalculadoraJuros
{
    private double valorPresente;
    private double juros;
    private double periodo;
    private double MesSaque;

    public CalculadoraJuros(double valorPresente, double juros, double periodo, double MesSaque)
    {
        this.valorPresente = valorPresente;
        this.juros = juros / 100; 
        this.periodo = periodo;
        this.MesSaque = MesSaque;
    }

    public void CalcularJuros()
    {
        double rendimento;
        double valorFuturo;
        double saque;

        Console.WriteLine("| Mês | Taxa de Juros (%) | Valor Presente ($) | Valor Futuro  | Rendimento ($) | Saque |");

        for (int i = 1; i <= periodo; i++)
        {
            rendimento = valorPresente * juros;
            valorFuturo = valorPresente + rendimento;

            if (i == MesSaque)
            {
                Console.WriteLine($"Mês {i}: Qual o valor do saque?");
                saque = double.Parse(Console.ReadLine());
                valorFuturo -= saque;
            }
            else
            {
                saque = 0;
            }

            Console.WriteLine($"|  {i}  |        {juros * 100}%       |      {valorPresente:F2}       |     {valorFuturo:F2}     |  {rendimento:F2}    |   {saque}   |");

            valorPresente = valorFuturo;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Qual o valor investido?");
        double valorPresente = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual a taxa de juros?");
        double juros = double.Parse(Console.ReadLine());

        Console.WriteLine("Quantos meses?");
        double periodo = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual o mês de saque?");
        double MesSaque = double.Parse(Console.ReadLine());

        CalculadoraJuros calculadora = new CalculadoraJuros(valorPresente, juros, periodo, MesSaque);
        calculadora.CalcularJuros();
    }
}