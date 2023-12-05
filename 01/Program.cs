class Program{

    static void Main() {

        int a = 10;
        int b = 20;
        int c = (a + b) / 2;

        c = c- 40;

        int [] v = new int [7];
        v[3] = a + b + c;

        Console.Write(v[3]);

    }
}
