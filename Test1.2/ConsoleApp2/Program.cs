class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число: ");
        int number;
        bool Proverka = Int32.TryParse(Console.ReadLine(), out number);

        if (Proverka)
        {
            if (number % 5 == 2 && number % 7 == 1)
            {
                Console.WriteLine("Число удовлетворяет всем критериям.");
            }
            else
            {
                Console.WriteLine("Число не удовлетворяет критериям.");
            }
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}