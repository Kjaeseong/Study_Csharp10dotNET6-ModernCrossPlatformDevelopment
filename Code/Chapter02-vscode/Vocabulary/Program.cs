using System.Reflection;
using System;


// 추가된 어셈블리의 형식을 사용해
// 사용하지 않는 변수를 몇 개 선언했음
System.Data.DataSet ds;
HttpClient client;

Assembly? assembly = Assembly.GetEntryAssembly();
if(assembly == null)
{
    return;
}

// 이 프로그램이 참조하는 어셈블리를 순회한다
foreach(AssemblyName name in assembly.GetReferencedAssemblies())
{
    // 세부 정보를 읽기 위해 어셈블리 로드
    Assembly a = Assembly.Load(name);

    // 전체 메서드 수를 저장할 변수 선언
    int methodCount = 0;

    // 어셈블리의 모든 형식 순회
    foreach(TypeInfo t in a.DefinedTypes)
    {
        // 메서드의 수량을 누적시킨다
        methodCount += t.GetMethods().Count();
    }

    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount, arg2: name.Name
    );
}