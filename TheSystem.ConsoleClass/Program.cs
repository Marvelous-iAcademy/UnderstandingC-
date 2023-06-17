class Sample
{
    static void Main()
    {
        // Console is a member of system NameSpace that performes I/ O operations
            //is a static class. members are accessible without creating any object for the "console" class
            // member are void Write(), void WriteLine(), void ReadKey(), string ReadLine, Void Clear()


        // Print messages line-by-line
        System.Console.WriteLine("Welcome");
        System.Console.WriteLine("to");
        System.Console.WriteLine("C# Programming");

        // Print messages side-by-side
        System.Console.Write("Welcome");
        System.Console.Write(" to");
        System.Console.Write(" C# Programming");

        // wiat for pressing some key on key board
        System.Console.ReadKey();

        // clear the screen
        System.Console.Clear();

        System.Console.WriteLine("Thank you.");
        System.Console.ReadKey();
    }
}