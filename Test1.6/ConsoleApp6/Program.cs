class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        string chve = Convert.ToString(number, 8);
        if (chve.Length >= 2)
        {
            char second_right = chve[chve.Length - 2];
            Console.WriteLine("Вторая справа цифра в восьмеричной системе: " + second_right);
        }
        else
        {
            Console.WriteLine("Введенное число имеет меньше двух цифр в восьмеричной системе");
        }
    }
}