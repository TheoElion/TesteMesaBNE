class Program{

    static void Main() {

        int a = 2;
        int [] v = new int [7];

        while (a < 6)
        {
            v[a] = 10 * a;
            a += 1;
        } ;
        Console.Write(v[2]);
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine($"Vetor {i} o resultado e {v[i]}");
        }
    }
}