class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число: ");
        int number;
        bool Proverka = Int32.TryParse(Console.ReadLine(), out number);

        if (Proverka)
        {
            if (number >= 5 && number <= 10)
            {
                Console.WriteLine("Число в промежутке от 5 до 10");
            }
            else
            {
                Console.WriteLine("Число не в промежутке от 5 до 10");
            }
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}