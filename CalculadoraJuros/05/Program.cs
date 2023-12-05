class Program {

    static void Main() {

        double valorPresente = 3800;
        double juros = 0.0125;
        double periodo = 24;
        double valorFuturo = 7390.61;


        valorPresente = valorFuturo / Math.Pow((1 + juros), periodo);
        
        Console.WriteLine($"Para obter o valor de R${valorFuturo} é nescessario investir: {valorPresente:F2}");
    }
}
