private static void IterateThruDictionary
{
	Dictionary<string,Element> elements = BuildDictionary();

	foreach(KeyValuePair<string, Element> kvp in elements)
	{
		Element theElement = kvp.Value;

		Console.WriteLine("Key: " + kvp.Key);
		Console.WriteLine("values: " + theElement.Symbol + " " +
			theElement.Name + " " + theElement.AtomicNumber);
	}
}

private static Dictionary<string, Element> BuildDictionary()
{
	var elements = new Dictionary<string, Element>();

	AddToDictionary(elements, "K", "Potassium", 19);
    AddToDictionary(elements, "Ca", "Calcium", 20);
    AddToDictionary(elements, "Sc", "Scandium", 21);
    AddToDictionary(elements, "Ti", "Titanium", 22);

    return elements;
}

private static void AddToDictionary(Dictionary<string, Element> elements, string symbol, string name, int atomicNumber)
{
	Element theElement = new Element();

	theElement.Symbol = symbol;
	theElement.Name = name;
	theElement.AtomicNumber = atomicNumber;

	elements.Add(key: theElement.Symbol, value: theElement);
}

public class Element
{
	public string Symbol { get; set; }
	public string Name { get; set; }
	public int AtomicNumber { get; set; }

}