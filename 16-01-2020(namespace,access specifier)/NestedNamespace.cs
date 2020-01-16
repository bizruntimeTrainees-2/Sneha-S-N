using System;

namespace MyNameSpace
{
namespace Nested
{
	public class SampleClass
	{
		public static void myMethod()
		{
			Console.WriteLine("Nested Namespace Example");
		}
	}
}
}

namespace MyProgram
{
    public class NestedNamespace
	{
		static void Main(string[] args)
		{
			MyNameSpace.Nested.SampleClass.myMethod();
		}
	}
}