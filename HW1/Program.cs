namespace Module17HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Счёта Тома:" + Environment.NewLine);

            ICalculateInterest iCalculateInterest = new ClassObychnyAccount();
            ICalculateInterest iCalculateInterest2 = new ClassZarplatnyAccount();

            ClassUser Tom = new ClassUser("159-05", "Tom");
            Tom.PrintAcc();
            Tom.Type = "обычный";
            Tom.Balance = 1999;
            Tom.Interest = 0.2;

            iCalculateInterest.CalculateInterest(Tom);
            iCalculateInterest2.CalculateInterest(Tom);

            Console.ReadKey();
        }
    }
}