class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        string binaryks3 = Convert.ToString(number, 2);

        if (binaryks3.Length >= 2)
        {
            binaryks3 = binaryks3.Substring(0, binaryks3.Length - 2) + 
                (binaryks3[binaryks3.Length - 2] == '0' ? '1' : '0') + binaryks3.Substring(binaryks3.Length - 1);

            int chiclo = Convert.ToInt32(binaryks3, 2);
            Console.WriteLine("Число с измененным значением второго бита: " + chiclo);
        }
        else
        {
            Console.WriteLine("Введенное число имеет меньше двух битов в бинарном представлении");
        }
    }
}