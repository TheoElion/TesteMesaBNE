
class Program {

    static void Main() {

        double valorPresente = 0;
        double juros = 0;
        double periodo = 1;
        double rendimento = 0;
        double valorFuturo = 0;
        double saque = 0;

        Console.WriteLine("Qual o valor investido?");
        valorPresente = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Qual a taxa de juros?");
        juros = double.Parse(Console.ReadLine())/100;


        Console.WriteLine("| Mês | Taxa de Juros (%) | Valor Presente ($)  | Valor Futuro  | Rendimento ($) | Saque |");

        for (int i = 1; i <= 6; i++)
        {
            /*valorFuturo = valorPresente * Math.Pow((1 + juros), periodo);
            rendimento = valorFuturo - valorPresente; */

            rendimento = valorPresente * juros;
            valorFuturo = valorPresente + rendimento;

            if(periodo == 5) {
                Console.WriteLine("Qual o valor do saque no 5 mes?");
                saque = double.Parse(Console.ReadLine());
                valorFuturo -= saque;
                periodo = 0;

            } else {
                saque = 0;
            }

            Console.WriteLine($"|  {periodo}  |        2%         |      {valorPresente:F2}       |     {valorFuturo:F2}     |  {rendimento:F2}    |   {saque}   |");


            valorPresente = valorFuturo;

            periodo++;
        }
    }
}