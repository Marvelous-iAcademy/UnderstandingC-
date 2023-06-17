class Operators
{
    static void Main()
    {
        // Arithmetical Operators
        decimal a = 10M;
        decimal b = 3M;
        decimal c = a + b;
        decimal d = a - b;
        decimal e = a * b;
        decimal f = a / b;
        decimal g = a % b;
        System.Console.WriteLine(c);
        System.Console.WriteLine(d);
        System.Console.WriteLine(e);
        System.Console.WriteLine(f);
        System.Console.WriteLine(g);

        // Assignment Operators
        a += 20;
        System.Console.WriteLine(a); // output = 30
        a -= 20;
        System.Console.WriteLine(a); // output = 10
        a *= 3M;
        System.Console.WriteLine(a); // output = 30
        a /= 3M;
        System.Console.WriteLine(a); // output = 3
        a %= 3M;
        System.Console.WriteLine(a); // output = 1

        // Increment / Decrement Operators
        a = 10M;
        System.Console.WriteLine(++a); // output 11
        System.Console.WriteLine(a++); // output 11
        System.Console.WriteLine(a); // output 12
        System.Console.WriteLine(--a); // output 11
        System.Console.WriteLine(a--); // output 11
        System.Console.WriteLine(a); // output 10

        // Comparison Operators
        bool b1 = a == 10;
        System.Console.WriteLine(b1); // true
        bool b2 = a != 10;
        System.Console.WriteLine(b2); // false
        bool b3 = a < 10;
        System.Console.WriteLine(b3); // false
        bool b4 = a > 10;
        System.Console.WriteLine(b4); // false
        bool b5 = a >= 10;
        System.Console.WriteLine(b5); // true
        bool b6 = a <= 10;
        System.Console.WriteLine(b6); // true

        // Logical Operators
        bool b7 = a == 10 && b == 10;
        System.Console.WriteLine(b7);
        bool b8 = a == 10 && b == 10;
        System.Console.WriteLine(b8);
        bool b9 = a == 10 && b == 10;
        System.Console.WriteLine(b9);
        //bool b10 = a == || b == 10;
        //System.Console.WriteLine(b10);
        bool b11 = !(a == 10);
        System.Console.WriteLine(b11);
        bool b12 = a == 10 ^ b == 10;
        System.Console.WriteLine(b12);

        // Concatenation Operator
        string name = "Bolu";
        int age = 20;
        string message = "Hey," + name + ", your age is " + age;

        // ternary operator
        string title = (age < 13) ? "Child" : (age >= 13 && age <= 19) ? "Teenager" : "Adult";
        System.Console.WriteLine(title);  // Outputs Adult

        // Operator precedence
        double z = 10 + 4 * 30 / 10;
        System.Console.WriteLine(z); // Output 22

        System.Console.ReadKey();

    }
}