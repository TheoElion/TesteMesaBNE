class Program {

    static void Main() {

        double valorPresente = 20000;
        double juros = 0.02;
        double periodo = 1;
        double rendimento = 0;
        double valorFuturo = 0;
        double saque = 0;


        Console.WriteLine("| Mês | Taxa de Juros (%) | Valor Presente ($)  | Valor Futuro  | Rendimento ($) | Saque |");

        for (int i = 1; i <= 6; i++)
        {
            valorFuturo = valorPresente * Math.Pow((1 + juros), periodo);
            rendimento = valorFuturo - valorPresente;

            if(periodo == 5) {
                saque = 5000;
                valorPresente -= saque;
                periodo = 0;

            } else {
                saque = 0;
            }

            Console.WriteLine($"|  {periodo}  |        2%         |      {valorPresente:F2}       |     {valorFuturo:F2}     |  {rendimento:F2}    |   {saque}   |");


            periodo++;
        }

    }
}