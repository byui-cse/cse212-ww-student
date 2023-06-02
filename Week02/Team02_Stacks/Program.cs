using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(ComplexStackExample.DoSomething("(a == 3 or (b == 5 and c == 6))"));
        Console.WriteLine(ComplexStackExample.DoSomething("(students]i].Grade > 80 and students[i].Grade < 90)"));
        Console.WriteLine(ComplexStackExample.DoSomething("(robot[id + 1].Execute(.Pass() || (!robot[id * (2 + i)].Alive && stormy) || (robot[id - 1].Alive && lavaFlowing))"));
    }
}