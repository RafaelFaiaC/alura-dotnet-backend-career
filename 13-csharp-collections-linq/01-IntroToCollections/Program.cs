using System.Collections;

DayOfWeekCollection daysOfWeek = new DayOfWeekCollection();

List<Product> shoppingCart = new List<Product>
{
    new Product { Name = "Laptop", Price = 999.99m },
    new Product { Name = "Smartphone", Price = 499.99m },
    new Product { Name = "Headphones", Price = 199.99m }
};

//daysOfWeek[0];
//shoppingCart[0];

//var evenNumbers = EvenNumbersWithoutYield(10000);
var evenNumbers = EvenNumbersWithYield(10000);
var counter = 0;
foreach (var even in evenNumbers)
{
    counter++;
    Console.WriteLine(even);
    if (counter == 5) break;

}

IEnumerable<int> EvenNumbersWithoutYield(int limit)
{
    List<int> evenNumbers = new List<int>();
    for (int i = 0; i <= limit; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine("Processing element " + i);
            evenNumbers.Add(i);
        }
    }
    return evenNumbers;
}

IEnumerable<int> EvenNumbersWithYield(int limit)
{
    for (int i = 0; i <= limit; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine("Processing element " + i);
            yield return i;
        }
    }
}

void IterateWithEnumerator()
{
    var enumerator = daysOfWeek.GetEnumerator();
    while (enumerator.MoveNext())
    {
        var day = enumerator.Current;
        Console.WriteLine(day);
    }
}

void IterateDaysOfWeek()
{
    foreach (var day in daysOfWeek)
    {
        Console.WriteLine(day);
    }
}

void IterateWithFor()
{
    for (int i = 0; i < shoppingCart.Count; i++)
    {
        Product product = shoppingCart[i];
        Console.WriteLine($"Product: {product.Name}");
    }
}

void IterateWithForeach()
{
    foreach (Product product in shoppingCart)
    {
        Console.WriteLine($"Product: {product.Name}");
    }
}

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class DayOfWeekCollection : IEnumerable<string>
{
    public IEnumerator<string> GetEnumerator()
    {
        yield return "Monday";
        yield return "Tuesday";
        yield return "Wednesday";
        yield return "Thursday";
        yield return "Friday";
        yield return "Saturday";
        yield return "Sunday";
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

//class DaysOfWeekEnumerator : IEnumerator<string>
//{
//    private int position = -1;
//    private string[] days = new string[]
//    {
//        "Monday",
//        "Tuesday",
//        "Wednesday",
//        "Thursday",
//        "Friday",
//        "Saturday",
//        "Sunday"
//    };
    
//    public string Current => days[position];

//    object IEnumerator.Current => Current;

//    public void Dispose() { }

//    public bool MoveNext()
//    {
//        position++;
//        return (position < days.Length);
//    }

//    public void Reset()
//    {
//        position = -1;
//    }

//}