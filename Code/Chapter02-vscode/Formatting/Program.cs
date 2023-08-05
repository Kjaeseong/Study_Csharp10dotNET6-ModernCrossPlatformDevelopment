using System;



class Program
{
    static void Main(string[] args)
    {
        // TextFormat tf = new();
        // tf.Method();

        Interpolation interp = new();
        interp.Method();
    }
}

public class TextFormat
{
    int numberOfApples = 12;
    decimal pricePerApple = 0.35M;

    public void Method()
    {
        // 이렇게 쓸 수도 있고
        Console.WriteLine(
            format: "{0} apples costs {1:C}",
            arg0: numberOfApples,
            arg1: pricePerApple * numberOfApples
        );

        // 이렇게 할 수도 있다.
        string formatText = string.Format(
            format: "{0} apples costs {1:C}",
            arg0: numberOfApples,
            arg1: pricePerApple * numberOfApples
        );
        Console.WriteLine(formatText);
    }
}

public class Interpolation
{
    int Value = 10;

    public void Method()
    {
        string p = $"value : {Value}";
        Console.WriteLine(p);
    }
}