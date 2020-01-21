using System;

class MyGenericClass<int> intGenericClass = new MyGenericClass<int>(10);

class MyGenericClass<T>
{
	private T genericMemberVariable;

	public MyGenericClass(T value)
	{
		genericMemberVariable = value;
	}

    public T genericMethod<U>(T genericParameter, U anotherType) where U:struct 
    {
	    Console.WriteLine("Generic Parameter of type {0}, value {1}", typeof(T).ToString(),genericParameter);
	    Console.WriteLine("Return value of type {0}, value {1}", typeof(T).ToString(),genericParameter);

	    return generic genericMemberVAriable;
    }

public T genericProperty { get; set; }
}