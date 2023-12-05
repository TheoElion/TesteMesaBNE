class Program {

    static void Main() {

        double valorPresente = 0;
        double juros = 0;
        double periodo = 8.33;
        double valorFuturo = 0;

        Console.WriteLine("Qual o valor investido?");
        valorPresente = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Qual a taxa de juros?");
        juros = double.Parse(Console.ReadLine())/100;


        valorFuturo = valorPresente * Math.Pow((1 + juros), periodo);

        Console.WriteLine($"Em 8 meses e 10 dias voce terá: {valorFuturo:F2}");
    }
}
