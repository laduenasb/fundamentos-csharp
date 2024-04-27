// See https://aka.ms/new-console-template for more information
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