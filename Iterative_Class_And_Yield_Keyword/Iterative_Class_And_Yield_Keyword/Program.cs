

using System.Collections;

//Stock stock = new Stock();
//foreach (var item in stock)
//{
//    Console.WriteLine(item);    
//}

//class Stock
//{
//    List<string> products = new() { "computer", "phone", "TV", "watch"};
//    public void Add(string product)=> products.Add(product);


//    public IEnumerator<string> GetEnumerator()
//    {
//        return new StockEnumerator(products);
//    }
//}



//class StockEnumerator : IEnumerator<string>
//{

//    List<string> sources;
//    public StockEnumerator(List<string> sources)=> this.sources = sources;

//    int currentIndex = 1;


//    public string Current => sources[currentIndex];

//    object IEnumerator.Current => sources[currentIndex];

//    public void Dispose()=> sources = null;
//    public bool MoveNext()=> ++currentIndex<sources.Count;

//    public void Reset() => currentIndex = -1;
//}



#region Yield keyword


Test test = new Test();

foreach (var item in test.Settings())
{
    Console.WriteLine($"{item.key}:{item.value}");
}

class Test
{ 

    //public IEnumerable<(string key, string value)> Settings()
    //{
    //    List<(string, string)> settings = new()
    //    {
    //        ("connection","..."),
    //        ("color","blue"),
    //        ("role","user"),
    //    };

    //    return settings;
    //}


    // yield keyword
    public IEnumerable<(string key, string value)> Settings()
    {
        yield return ("connection","...");
        yield return ("color","green");
        yield return ("role","user");
    }


}

 

#endregion
