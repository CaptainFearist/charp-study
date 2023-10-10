class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        string binaryks2 = Convert.ToString(number, 2);

        if (binaryks2.Length >= 4)
        {
            char[] binaryArray = binaryks2.ToCharArray();
            binaryArray[binaryks2.Length - 4] = '0';
            binaryks2 = new string(binaryArray);

            int chiselko = Convert.ToInt32(binaryks2, 2);
            Console.WriteLine("Число с установленным четвертым битом равным нулю: " + chiselko);
        }
        else
        {
            Console.WriteLine("Введенное число имеет меньше четырех битов в бинарном представлении");
        }

    }
}