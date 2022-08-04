// See https://aka.ms/new-console-template for more information
Console.WriteLine("***CALCULADORA DE MONTOS***");
Console.WriteLine("");

//DECLARACION DE VARIABLES

double precio;
int cantidad;

Console.WriteLine("INGRESE EL PRECIO DEL PRODUCTO C$: ");
precio = double.Parse(Console.ReadLine());

Console.WriteLine("INGRESE LA CANTIDAD SELECCIONADA: ");
cantidad = int.Parse(Console.ReadLine());

double monto = precio * cantidad;


Console.WriteLine("------------------------------------------");
Console.WriteLine("MONTO A CANCELAR EN C$: " +monto.ToString("0.00"));


//Console.ReadLine();

