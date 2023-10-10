class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        string binaryks = Convert.ToString(number, 2);

        if (binaryks.Length >= 3)
        {
            char[] binaryArray = binaryks.ToCharArray();
            binaryArray[binaryks.Length - 3] = '1';
            binaryks = new string(binaryArray);

            int newNumber = Convert.ToInt32(binaryks, 2);
            Console.WriteLine("Число с установленным третьим битом: " + newNumber);
        }
        else
        {
            Console.WriteLine("Введенное число имеет меньше трех битов в бинарном представлении");
        }
    }
}