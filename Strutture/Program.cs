using Strutture;

MyClass myClass = new MyClass();
myClass.myInteger = 10;
myClass.myString = "dieci";

MyStruct myStruct = new MyStruct();
myStruct.myInteger = 20;
myStruct.myString = "venti";

Console.WriteLine($"---------------------");
Console.WriteLine($"{myClass.myInteger}");
Console.WriteLine($"{myClass.myString}");
Console.WriteLine($"{myStruct.myInteger}");
Console.WriteLine($"{myStruct.myString}");

ClassMethod(myClass, myStruct, 30, "trenta");

Console.WriteLine($"---------------------");
Console.WriteLine($"{myClass.myInteger}");
Console.WriteLine($"{myClass.myString}");
Console.WriteLine($"{myStruct.myInteger}");
Console.WriteLine($"{myStruct.myString}");

static void ClassMethod(MyClass mc, MyStruct ms, int i, string s){
    mc.myInteger = i;
    ms.myInteger = i;
    mc.myString = s;
    ms.myString = s;
}

