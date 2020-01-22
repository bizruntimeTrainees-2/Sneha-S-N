Func<int, int> square = x => x * x;
Console.WriteLine(square(5));
//Output:25

System.Linq.Expression<Fun<int, int>> e = x => x * x;
Console.WriteLine(e);
//Output:x => (x * x)

int[] numbers = { 2, 3, 4, 5};
var squareNumbers = numbers.Select(x => x * x);
Console.WriteLine(string.Join(" ", squareNumbers));
//Output:
//4 9 16 25

Action<string> greet = name =>
{
	string greeting = $"Hello {name}!";
	Console.WriteLine(greeting);
};
greet("World");
//Output: Hello World!