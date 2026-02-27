using System;

partial class Person
{
    public string Name => "홍길동";
    public int Age => 25;
}

partial class Person
{
    public void Print()
    {
        Console.WriteLine($"{Name}: {Age}");
    }
}