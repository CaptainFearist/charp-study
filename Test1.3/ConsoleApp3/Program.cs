class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число: ");
        int number;
        bool Proverka = Int32.TryParse(Console.ReadLine(), out number);

        if (Proverka)
        {
            if (number % 4 == 0 && number >= 10)
            {
                Console.WriteLine("Число делится на 4 и не меньше 10");
            }
            else
            {
                Console.WriteLine("Число не делится на 4 или меньше 10");
            }
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}