using FundamentosCSHARP.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        // Variables
        Console.WriteLine("Hello, World!");

        decimal numero = 189.1m;

        char caracter = 'A';

        bool siOno = true;

        string cadena = "hola mundo";

        DateTime date = DateTime.Now;

        int? numero2 = null;

        Console.WriteLine(numero2.ToString());


        var nombre = "Alejandro Dueñas"; // Var es permitido en un metodo, no funciona como atributo de la clase

        var limite = 50;
        var persona = new { nombre = "Alejandro", apellido = "Dueñas", edad = 20 };

        Console.WriteLine(nombre);

        Console.WriteLine(persona.edad);

        // Clases

        Bebida bebida = new Bebida("Coca cola", 1000);
        bebida.Beberse(550);

        Console.WriteLine(bebida.Cantidad);

        Cerveza cerveza = new Cerveza("Cerveza stout", 80);
        cerveza.Beberse(10);

        Console.WriteLine(cerveza.Cantidad);

        // Arreglos y listas

        int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        int numero_x = numeros[9];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Iteración: "+i+" - "+numeros[i]);
        }

        foreach (var numero_i in numeros)
        {
            Console.WriteLine(numero_i);
        }
        Console.WriteLine("**************************************");

        List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8};
        lista.Add(9);
        lista.Add(10);
        lista.Remove(2);

        foreach (var numero_i in lista)
        {
            Console.WriteLine("Elemento: "+numero_i);
        }

        List<Cerveza> lista_cervezas = new List<Cerveza>() { new Cerveza("Heineken", 500)};
        lista_cervezas.Add(new Cerveza("Poker"));
        Cerveza erdinger = new Cerveza("Cerveza de trigo", 500);
        lista_cervezas.Add(erdinger);

        foreach(var cerveza_i in lista_cervezas)
        {
            Console.WriteLine("Cerveza: " + cerveza_i.Nombre);
        }

        // Interfaces

        Console.WriteLine("**************************************************");

        var bebidaAlcoholica = new Cerveza("Cervaza roja");
        Console.WriteLine(bebidaAlcoholica.Nombre);
        MostrarRecomendacion(bebidaAlcoholica);
        List<String> hola = new List<String>();

        Console.WriteLine("****************************************************");

        CervezaBD cervezaBD = new CervezaBD();

        // Insertamos una nueva cerveza
        /*
        {
            Cerveza cerveza_nueva = new Cerveza("Pale ale", 80);
            cerveza_nueva.Marca = "Minerva";
            cerveza_nueva.Alcohol = 4;
            cervezaBD.Add(cerveza_nueva);
        }
        */

        // Editamos una cerveza
        /*
        {
            Cerveza cerveza_nueva = new Cerveza("Pale ale 2", 50);
            cerveza_nueva.Marca = "Minerva 2";
            cerveza_nueva.Alcohol = 5;
            cervezaBD.Edit(cerveza_nueva, 5);
        }
        */

        // Eliminamos una cerveza
        {
            cervezaBD.Delete(5);
        }

        {

        }

        // Obtener todas las cervezas
        var cervezas = cervezaBD.Get();

        foreach(var cerveza_lista in cervezas)
        {
            Console.WriteLine(cerveza_lista.Nombre);
        }   
    }

    static void MostrarRecomendacion(IBebidaAlcoholica bebida)
    {
        bebida.MaxRecomendado();
    }
}