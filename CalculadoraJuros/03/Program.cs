class Program {

    static void Main() {

        double valorPresente = 0;
        double juros = 0;
        double periodo = 0;
        double valorFuturo = 0;

        Console.WriteLine("Qual o valor investido?");
        valorPresente = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Qual a taxa de juros?");
        juros = double.Parse(Console.ReadLine())/100;

        Console.WriteLine("Qual o periodo em anos?");
        periodo = double.Parse(Console.ReadLine());

        valorFuturo = valorPresente * Math.Pow((1 + juros), periodo);

        Console.WriteLine(valorFuturo);
        
    }
}
