class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int pobit = number >> 2;
        int third_bit = pobit & 1;

        Console.WriteLine("Третий бит справа в двоичном представлении: " + third_bit);
    }
}