class Program
{
    public static void Main(string[] args)
    {
        RandomNumber randomNumber = new RandomNumber();

        int number = randomNumber.GetNumber();

        Console.WriteLine(number);
    }
}

public class RandomNumber
{
    public int GetNumber()
    {
        int minValue = -100;
        int maxValue = 1000;

        Random random = new Random();

        return random.Next(minValue, maxValue + 1);
    }
}