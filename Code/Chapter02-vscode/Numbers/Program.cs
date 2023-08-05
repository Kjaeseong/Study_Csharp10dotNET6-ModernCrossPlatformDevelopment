using System;

class Program
{
    static void Main(string[] args)
    {
        // Second second = new Second();
        // second.Method();

        // Third third = new Third();
        // third.Method();

        // Fourth fourth = new Fourth();
        // fourth.Method();

        Fifth fifth = new Fifth();
        fifth.Method();
    }
}


public class First
{
    uint naturalNumber = 23;
    int integerNumber = -23;
    float realNumber = 2.3f;
    double anotherRealNuber = 2.3;
}


public class Second
{
    int decimalNotation = 2_000_000;
    int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
    int hexadecimalNotation = 0x_001E_8480;

    public void Method()
    {
        Console.WriteLine($"{decimalNotation == binaryNotation}");
        Console.WriteLine($"{decimalNotation == hexadecimalNotation}");
    }
}

public class Third
{
    public void Method()
    {
        Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in ther range {int.MinValue:N0} ~~ {int.MaxValue:N0}.");
        Console.WriteLine($"double used {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} ~~ {double.MaxValue:N0}.");
        Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} ~~ {decimal.MaxValue:N0}.");
    }
}

public class Fourth
{
    double a = 0.1;
    double b = 0.2;

    public void Method()
    {
        if(a + b == 0.3)
        {
            Console.WriteLine($"{a} + {b} = 0.3");
        }
        else
        {
            Console.WriteLine($"{a} + {b} /= 0.3");
        }
    }
}

public class Fifth
{
    decimal a = 0.1M;
    decimal b = 0.2M;

    public void Method()
    {
        if(a + b == 0.3M)
        {
            Console.WriteLine($"{a} + {b} = 0.3");
        }
        else
        {
            Console.WriteLine($"{a} + {b} /= 0.3");
        }
    }
}