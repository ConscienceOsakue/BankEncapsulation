namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var kelAccount = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");

            var amountToDep = double.Parse(Console.ReadLine());


            kelAccount.Deposit(amountToDep);
            Console.WriteLine($"Your Balace is now {kelAccount.GetBalance()}");

        }
    }
}
