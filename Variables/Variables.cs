class VariablesExample
{
    // Variable is a named memory location in a RAM to store a particular type of Value during program execution
    // Variables are stored in a Stack
    // variables must be declared before its usage
    // since the value can be changed it is a variable
    // DataType VariableName = value;
    // setting value to a variable is called assignment
    // Camel case is used for naming a variable eg StudentName
    static void Main()
    {
        // declare the local variables 
        string studentName = "Scott,";
        int age = 20;
        // print value
        
        System.Console.WriteLine("Hey");
        System.Console.WriteLine(studentName);
        System.Console.WriteLine(" your age is: ");
        System.Console.WriteLine(age);
        // wait for pressing some key on the keyboard
        System.Console.ReadKey();

    }
}