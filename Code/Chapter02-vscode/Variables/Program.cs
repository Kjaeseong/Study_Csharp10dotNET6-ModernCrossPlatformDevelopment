

class Program
{
    static void Main(string[] args)
    {
        // ObjectTest obj = new ObjectTest();
        // obj.Method();

        // DynamicTest dyn = new DynamicTest();
        // dyn.Method();

        // NewTest n = new(15);
        // n.Print();

        TypeDefaultTest def = new();
        def.Method();
    }
}

public class ObjectTest
{
    object height = 1.88;
    object name = "Amir";

    public void Method()
    {
        Console.WriteLine($"{name} is {height} meters tall.");

        // 컴파일 에러, 명시적으로 형변환 해야 함 object 타입에는 Length라는 속성이 없기 때문
        // int length = name.Length;

        int length = ((string)name).Length; // 여기
        Console.WriteLine($"{name} has {length} characters.");
    }
}

public class DynamicTest
{
    dynamic name = "Ahmed";
    dynamic something = 12;

    public void Method()
    {
        Console.WriteLine($"name Length : {name.GetType().Name} / {name.Length}");
        
        Console.WriteLine($"something Value : {something.GetType().Name} / {something}");
        
        // 런타임에서 타입 변환
        something = new[] {3, 5, 7};
        Console.WriteLine($"something Length : {something.GetType().Name} / {something.Length}");
        for(int i = 0; i < something.Length; i++)
        {
            Console.WriteLine(something[i]);
        }
    }
}

public class VarTest
{
    public void Method()
    {
        // 컴파일 단계에서 타입 추론
        var v = new int[5];
    }
}

public class NewTest
{
    public int Value;
    public NewTest(int value)
    {
        Value = value;
    }
    public void Print()
    {
        Console.WriteLine(Value);
    }
}

public class TypeDefaultTest
{
    public int intValue = 15;

    public void Method()
    {
        Console.WriteLine(intValue);
        intValue = default;
        Console.WriteLine(intValue);
    }
}