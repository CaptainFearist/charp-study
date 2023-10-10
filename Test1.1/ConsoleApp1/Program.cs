class Program1
{
    static void Main()
    {
        Console.WriteLine("Введите число: ");
        int number;
        bool Proverka = Int32.TryParse(Console.ReadLine(), out number);

        if (Proverka)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("Число делится на 3.");
            }
            else
            {
                Console.WriteLine("Число не делится на 3.");
            }
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}