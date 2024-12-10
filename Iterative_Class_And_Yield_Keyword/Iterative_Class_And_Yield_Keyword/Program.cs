

using System.Collections;

Stock stock = new Stock();

foreach (var item in stock)
{
    Console.WriteLine(item);    
}

class Stock
{
    List<string> products = new() { "computer", "phone", "TV", "watch"};
    public void Add(string product)=> products.Add(product);


    public IEnumerator<string> GetEnumerator()
    {
        return products.GetEnumerator();
    }
}

