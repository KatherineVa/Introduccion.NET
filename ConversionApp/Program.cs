// See https://aka.ms/new-console-template for more information

Console.WriteLine("CONVERTIDOR DE MEDIDAS");
Console.WriteLine("INGRESE CANTIDAD EN METROS");
double metros = double.Parse(Console.ReadLine());

//en centimetros
double cm = metros * 100;
double pulg = cm / 2.54;
double pies = pulg / 12;
double yardas = pies / 3;
Console.WriteLine("RESULTADOS-------------");
Console.WriteLine("CENTIMETROS: " +cm+ " PULGADAS: " +pulg+ " PIES: " +pies+ " YARDAS: " +yardas);
