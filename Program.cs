internal class Program
{
    private static void Main(string[] args)
    {
        string myName = "Mike";
        int myAge = 27;
        bool hasCar = true;
        double avgNum = 100.00;
        decimal myMoney = 100.00m;
        char middleInitial = 'a';

        Console.WriteLine($"Hello, my name is {myName}, my age is {myAge}, do i have a car {hasCar}, my number is {avgNum}, my money is {myMoney}, my middle initial is {middleInitial}");
    }
}