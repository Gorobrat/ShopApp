using System.Net.Http.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var a = GetVandak<Dog>();
        var a2 = GetVandak<Cat>();


        var p = HttpGet<Prod>("api/prods/5");
        var pp = HttpGet<List<Prod>>("api/prods");
        //pp.
        

        //Console.WriteLine(p.Data.Kendani.Parod);

    }

    private static Vandak<T> GetVandak<T>()
    {
        return default;
    }

    private static FullResponse<T> HttpGet<T>(string url)
    {
        // getting json string from api
        // deserialize json string to T obj
        // return obj
        return default;
    }
}

class Vandak<T>
{
    public T Kendani;
}


class Dog
{
    public string Parod;
}

class Cat
{

}

class Prod
{
    public string Name;
    public int Price;
}

class FullResponse<T>
{
    public FullResponse(string json)
    {
        Json = json;
        //Data = JsonConvert.de<T>(json);
    }

    public string Json;
    public T Data;
    // status code
}