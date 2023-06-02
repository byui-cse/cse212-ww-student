using System;
using System.Collections.Generic;

public class SimpleStackExample_Solution
{
    public static void Run()
    {
        var stack = new Stack<int>();
        // The solution notes here show the back of the stack to the right, so it is
        // easier to visualize the items that are added and removed.
        stack.Push(1);  // 1
        stack.Push(2);  // 1, 2
        stack.Push(3);  // 1, 2, 3
        stack.Pop();    // 1, 2
        stack.Pop();    // 1
        stack.Push(4);  // 1, 4
        stack.Push(5);  // 1, 4, 5
        stack.Pop();    // 1, 4
        stack.Push(6);  // 1, 4, 6
        stack.Push(7);  // 1, 4, 6, 7
        stack.Push(8);  // 1, 4, 6, 7, 8
        stack.Push(9);  // 1, 4, 6, 7, 8, 9
        stack.Pop();    // 1, 4, 6, 7, 8
        stack.Pop();    // 1, 4, 6, 7
        stack.Push(10); // 1, 4, 6, 7, 10
        stack.Pop();    // 1, 4, 6, 7
        stack.Pop();    // 1, 4, 6
        stack.Pop();    // 1, 4
        stack.Push(11); // 1, 4, 11
        stack.Push(12); // 1, 4, 11, 12
        stack.Pop();    // 1, 4, 11
        stack.Pop();    // 1, 4
        stack.Pop();    // 1
        stack.Push(13); // 1, 13
        stack.Push(14); // 1, 13, 14
        stack.Push(15); // 1, 13, 14, 15
        stack.Push(16); // 1, 13, 14, 15, 16
        stack.Pop();    // 1, 13, 14, 15
        stack.Pop();    // 1, 13, 14
        stack.Pop();    // 1, 13
        stack.Push(17); // 1, 13, 17
        stack.Push(18); // 1, 13, 17, 18
        stack.Pop();    // 1, 13, 17
        stack.Push(19); // 1, 13, 17, 19
        stack.Push(20); // 1, 13, 17, 19, 20
        stack.Pop();    // 1, 13, 17, 19
        stack.Pop();    // 1, 13, 17

        Console.WriteLine("Final contents:");
        // Using Reverse to show the top of the stack on the right
        Console.WriteLine(String.Join(", ", stack.ToArray().Reverse()));
    }
}

