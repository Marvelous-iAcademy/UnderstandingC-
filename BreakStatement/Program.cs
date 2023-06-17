class BreakStatement
{
    static void Main()
    {
        // for loop: 0 to 9
       /* for (int i = 0; i < 10; i++)
        {
            if(i == 5)
            {
                break;
            }
            Console.Write(i + " ");
        }
        Console.ReadKey();*/

        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                continue;
            }
            Console.WriteLine(i);
        }
        Console.ReadKey();
    }
}