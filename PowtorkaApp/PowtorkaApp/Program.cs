namespace PowtorkaApp;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę: ");
        var numbers = Console.ReadLine();
        char[] letters = numbers.ToArray();
        List<char> digits = new() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        foreach (char digit in digits) 
        {
            int counter = 0;
            foreach (var letter in letters) 
            {
                if (digit == letter)
                {  counter++; }
            }
            Console.WriteLine($"Liczba {digit} występuje {counter} razy");
        }

        //for (int i = 0; i < 10; i++)
        //{
        //    int counter = 0;
        //    foreach (var letter in letters)
        //    {
        //        int charInNumber = letter - '0';
        //        if (charInNumber == i)
        //        {
        //            counter++;
        //        }

        //    }
        //    Console.WriteLine("Liczba "+ i + " występuje " + counter+ " razy");
        //}

    }
}