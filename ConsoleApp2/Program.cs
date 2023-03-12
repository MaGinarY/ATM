namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please etner the amount of cash:");
            string cashString = Console.ReadLine();
            
            // As a extra task, if you have time. Please add the handling of incorrect input from user.
            // If you hover mouse over method 'ToInt32' you will see what exceptions it can throw.
            int cashInt = Convert.ToInt32(cashString);

            while(cashInt > 0)
            {
                var bankNote = ATM.Asd(cashInt);

                Console.WriteLine("Here you are:" + bankNote);

                cashInt -= bankNote;

            }

        }
    }
}


public static class ATM
{
    // It is better to give meanonfull names to Methods, Classes, variables, e.t.c.
    // So the code will be self-descriptive. It will help you to find out what is going on after long period of time,
    // or if new person reads your code, will take less time to undestand the logic.
    public static int Asd(int amount = 200)
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
