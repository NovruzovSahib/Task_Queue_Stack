using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //Queue
        Console.WriteLine("Queue");
        Queue<int> numbers = new();
        numbers.Enqueue(1);
        numbers.Enqueue(2);
        numbers.Enqueue(3);
        numbers.Enqueue(4);

        //Peek
        int number = numbers.Peek();
        Console.WriteLine($"Peek a number: {number}");

        //Dequeue
        int firstElement = numbers.Dequeue();
        Console.WriteLine($"Dequeue a number: {firstElement}");

        //Count
        int countElement = numbers.Count();
        Console.WriteLine($"Count a number: {countElement}");

        //Contains
        bool isExist = numbers.Contains(1);
        Console.WriteLine($"Is number contains: {isExist}");

        //Show numbers
        Console.WriteLine("Numbers");
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("=====================");

        Console.WriteLine("Stack");
        Stack<string> stack = new();
        stack.Push("Apple");
        stack.Push("Mango");
        stack.Push("Banana");
        stack.Push("Orange");

        //Peek
        string element1 = stack.Peek();
        Console.WriteLine($"Peek an element: {element1}");

        //Pop
        string element2 = stack.Pop();
        Console.WriteLine($"Pop an element: {element2}");

        //Count
        int element3 = stack.Count();
        Console.WriteLine($"Count an element: {element3}");

        //Contains
        bool element4 = stack.Contains("Mango");
        Console.WriteLine($"Is element contains: {element4}");

        //Show
        Console.WriteLine("Elements");
        foreach (var element in stack)
        {
            Console.WriteLine(element);
        }
        Console.ReadLine();
    }
}