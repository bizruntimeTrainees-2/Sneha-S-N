using System;
public class String22
{
	public static void Main(string[] args)
	{
		string a = new string(new[] {'a'});
		string b = new string(new[] {'b'});

        string.Intern(a);
		Console.WriteLine(string.IsInterned(a) != null);

		string.IsInterned(b);
		Console.WriteLine(string.IsInterned(b) != null);
	}
}