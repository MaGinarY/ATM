namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please etner the amount of cash:");
            string cashString = Console.ReadLine();
                        
            try
            {
                int cashInt = Convert.ToInt32(cashString);

                while (cashInt > 0)
                {
                    var bankNote = ATM.bankNoteLogic(cashInt);

                    Console.WriteLine("Here you are:" + bankNote);

                    cashInt -= bankNote;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, you should write a number !");
            }        
        }
    }
}

public static class ATM
{
    public static int bankNoteLogic(int amount = 200)
    {
        int twoHundred = 200;
        int oneHundred = 100;
        int fiveTeen = 50;
        int twenty = 20;
        int ten = 10;
        int five = 5;
        int one = 1;
        
        if(amount % twoHundred == 0)
        {
            return twoHundred;
        }

        if (amount % oneHundred == 0)
        {
            return oneHundred;
        }

        if (amount % fiveTeen == 0)
        {
            return fiveTeen;
        }

        if (amount % twenty == 0)
        {
            return twenty;
        }

        if (amount % ten == 0)
        {
            return ten;
        }

        if (amount % five == 0)
        {
            return five;
        }

        if (amount % one == 0)
        {
            return one;
        }

        return 0;
    }
}
