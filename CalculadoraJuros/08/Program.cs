class Program {

    static void Main() {

        double valorPresente = 0;
        double juros = 0;
        double contadorMes = 1;
        double periodo = 0;
        double rendimento = 0;
        double valorFuturo = 0;
        double saque = 0;
        double MesSaque = 0;


        Console.WriteLine("Qual o valor investido?");
        valorPresente = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Qual a taxa de juros?");
        juros = double.Parse(Console.ReadLine())/100;

        Console.WriteLine("Quantos meses?");
        periodo = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual o mes de saque?");
        MesSaque = double.Parse(Console.ReadLine());


        Console.WriteLine("| Mês | Taxa de Juros (%) | Valor Presente ($)  | Valor Futuro  | Rendimento ($) | Saque |");


        for (int i = 1; i <= periodo; i++)
        {
            /*valorFuturo = valorPresente * Math.Pow((1 + juros), periodo);
            rendimento = valorFuturo - valorPresente; */

            rendimento = valorPresente * juros;
            valorFuturo = valorPresente + rendimento;

            if(contadorMes == MesSaque) {
                Console.WriteLine("Qual o valor do saque?");
                saque = double.Parse(Console.ReadLine());
                valorPresente -= saque;

            } else {
                saque = 0;
            }

            Console.WriteLine($"|  {contadorMes}  |        2%         |      {valorPresente:F2}       |     {valorFuturo:F2}     |  {rendimento:F2}    |   {saque}   |");


            valorPresente = valorFuturo;

            contadorMes++;
        }
    }
}