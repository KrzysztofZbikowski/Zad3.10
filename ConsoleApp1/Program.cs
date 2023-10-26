class Zad
{
    static void Main(string[] args)
    {
        int n, wynik = 1, zm;
        Console.WriteLine("Podaj liczbę całkowitą");
        n = int.Parse(Console.ReadLine());
        zm = n;
        for (int i = 0; i<n; i++)
        {
            wynik = wynik * zm;
            zm--;
        }
        Console.WriteLine("{0} silnia wynosi: {1}", n, wynik);
        Console.ReadKey();
    }
}