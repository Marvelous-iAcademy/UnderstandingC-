class Sample
{
    static void Main()
    {
        // Static: The main method can be called without creating an object for the class by the CLR 
        // Void : The main method does not return any value!
        // Main : The entry point for the application 
        System.Console.WriteLine("Hello");
        // System is a predefined Namespace in the BCL
        // Inside the BCL we have a predefined namespace called Console
        // Inside the console class we have a predefined method called the WriteLine
        // The WriteLine mtd receives your value as arguement!
        System.Console.ReadKey();
        // System.Console.ReadKey(); tells the console class to wait until the user press a value on the key board!
    }
}