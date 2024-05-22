using FundamentosCSHARP.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        // Cerveza cerveza = new Cerveza("Cerveza", 55);
        // string miJson = JsonSerializer.Serialize(cerveza);
        // File.WriteAllText("objeto.txt", miJson);

        // Deserializar un objeto
        string miJson = File.ReadAllText("objeto.txt");
        Cerveza cerveza = JsonSerializer.Deserialize<Cerveza>(miJson);
        Console.WriteLine(cerveza.Marca);
    }
}