class Progam {
    static void Main() {

        double valorPresente = 3800;
        double juros = 1.25;
        double periodo = 1;
        double rendimento = 0;
        double valorFuturo = 0;

        Console.WriteLine("| Mês | Taxa de Juros (%) | Valor Futuro ($)  | Rendimento ($) | ");

        while (periodo <= 6)
        {
            rendimento = valorPresente * (juros / 100);
            valorFuturo = valorPresente + rendimento;

            Console.WriteLine($"|  {periodo}  |       1.25%       |      {valorFuturo:F2}      |      {rendimento:F2}     |");

            valorPresente = valorFuturo;

            periodo++;
        }
        
    }
}
