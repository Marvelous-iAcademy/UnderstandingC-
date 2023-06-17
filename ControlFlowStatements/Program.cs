class ControlStatements
{
    static void Main()
    {
        // Conditional Control Statements: if, if-else, else-if, nested-if

        int marks = 45;
        int marks2 = 69;
        char gradeLetter;
        
        if (marks >= 35)
        {
            System.Console.WriteLine("Congratulations!");
        }

        // if-else statements
        if (marks2 >= 35)
        {
            System.Console.WriteLine("Congratulations");
        }
        else
        {
            System.Console.WriteLine("Better Luck Next Time");
        }

        // else if statements
        if (marks2 > 69)
        {
            gradeLetter = 'A';
        }
        else if (marks2 >= 60 && marks2 < 69)
        {
            gradeLetter = 'B';
        }
        else if (marks2 >= 50 && marks2< 59)
        {
            gradeLetter = 'C';
        }
        else
        {
            gradeLetter = 'F';
        }

        // Nested if Statement


        // Looping Control Statements: while, do-while, for
        // Jumping Control Statements: goto, break, continue

        System.Console.ReadKey();
    }
}