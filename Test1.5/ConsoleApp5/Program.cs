class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        string input = Console.ReadLine();

        int number;
        bool Proverka = Int32.TryParse(input, out number);

        if (Proverka)
        {
            int thousand = (number / 1000) % 10;
            Console.WriteLine("Четвертая цифра справа: " + thousand);
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}