public class Program
{
    public static void Main()
    {
        double maxNum;
        int padFmt;
        double cube;

        Console.WriteLine("Learn your squares and roots.");
        do
        {
            Console.WriteLine("Enter an integer to begin: ");

            while (true)
            {
                maxNum = int.Parse(Console.ReadLine());
                cube = Math.Pow(maxNum, 3);

                switch (cube)
                {
                    case <= 0: // If maxNum is negative, its cube is negative also.
                        Console.WriteLine("This value is too low. Please enter something higher than 0.");
                        continue;

                    case > Int32.MaxValue:
                        Console.WriteLine("This value is too high. Please enter something at most " + (int)Math.Pow(Int32.MaxValue, 1.0 / 3.0));
                        continue;
                }

                if ((int)cube.ToString().Length < 7)
                    padFmt = 8;
                else
                    padFmt = (int)cube.ToString().Length + 1;

                break;
            }

            Console.WriteLine("Number".PadLeft(padFmt - 1) + "Squared".PadLeft(padFmt) + "Cubed".PadLeft(padFmt) + "\n"
                              + " ".PadLeft(padFmt, '=') + " ".PadLeft(padFmt, '=') + " ".PadLeft(padFmt, '='));

            for (int i = 1; i <= maxNum; i++)
                Console.WriteLine(i.ToString().PadLeft(padFmt - 1) + Math.Pow(i, 2).ToString().PadLeft(padFmt) + Math.Pow(i, 3).ToString().PadLeft(padFmt));

            Console.WriteLine("Would you like to do another number? y/n");

        } while (Console.ReadLine().ToLower() == "y");
    }
}