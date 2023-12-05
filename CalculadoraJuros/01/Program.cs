class Program {

    static void Main(){

        double valorPresente = 1000;
        double juros = 5.3 / 100;
        double periodo = 18;
        double valorFuturo = 0;


        valorFuturo = valorPresente * Math.Pow((1 + juros), periodo);

        Console.WriteLine(valorFuturo);
    }
}