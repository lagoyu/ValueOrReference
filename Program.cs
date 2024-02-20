using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program to illustrate call by reference & call by value");
        Console.WriteLine("=======================================================");
        Console.WriteLine();

        /* integers are value types rather than object types so to change them
         * through a procedure means they must be explicity passed by reference
         */
        Console.WriteLine("Integers are value types so default is call by value");
        int myNum = GetInt("  Enter myNum (integer) to be squared:");
        Console.WriteLine($"  Calling SquareVal(myNum) - call by value");
        SquareVal(myNum);
        Console.WriteLine($"    myNum value is {myNum}");

        Console.WriteLine($"  Calling SquareRef(ref myNum)");
        SquareRef(ref myNum);
        Console.WriteLine($"    myNum value is {myNum}");

        WaitClear();

        //Because an array is an object it is automatically passed by reference
        Console.WriteLine("Arrays are objects so default is call by reference");
        int[] values = { 1, 3, 10, 12, 11 };
        Console.WriteLine("initial array values");
        WriteIntArrayLines(values);
        Console.WriteLine($"Calling ChangeValue(values, 3, 100)");
        ChangeValue(values, 3, 100);
        Console.WriteLine("changed array values");
        WriteIntArrayLines(values);

        WaitClear();

        /*
         * Because strings are immutable they are normally passed by value so ref is
         * required if we want to change the reference to point at a newly constructed
         *  string
         */
        Console.WriteLine("Strings are objects but the objects they reference are immutable");
        Console.WriteLine(" so ref is required if we want to change the reference to point ");
        Console.WriteLine(" at a newly constructed string.");
        string name = "Paul";
        Console.WriteLine($"    name is \"{name}\"");
        Console.WriteLine($"    calling ChangeNameVal(name, \"Dave\")");
        ChangeNameVal(name, "Dave");
        Console.WriteLine($"        name is \"{name}\"");
        Console.WriteLine($"    calling ChangeNameRef(ref name, \"Dave\")");
        ChangeNameRef(ref name, "Dave");
        Console.WriteLine($"        name is \"{name}\"");

        WaitClear();
    }
    private static void SquareVal(int param)
    {
        param = param * param;
    }
    private static void SquareRef(ref int param)
    {
        param = param * param;
    }

    private static void ChangeValue(int[] localValues, int index, int newValue)
    {
        localValues[index] = newValue;
    }

    private static void ChangeNameVal(string name, string newname)
    {
        name = newname;
    }
    private static void ChangeNameRef(ref string name, string newname)
    {
        name = newname;
    }


    private static int GetInt(string prompt = "Enter number:")
    {
        Console.Write(prompt);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    private static void WaitClear()
    {
        Console.Write("\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }

    private static void WriteIntArrayLines(int[] values)
    {
        foreach (int x in values)
        {
            Console.Write($" {x}");
        }
        Console.WriteLine();
    }



}

