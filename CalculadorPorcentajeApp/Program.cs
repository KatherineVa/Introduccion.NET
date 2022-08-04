// See https://aka.ms/new-console-template for more information


Console.WriteLine("INGRESE MONTO 1 EN C$: ");
double monto1 = double.Parse(Console.ReadLine());
Console.WriteLine("INGRESE MONTO 2 EN C$: ");
double monto2 = double.Parse(Console.ReadLine());
Console.WriteLine("INGRESE MONTO 3 EN C$: ");
double monto3 = double.Parse(Console.ReadLine());

//CAPITAL
double capital = monto1 + monto2 + monto3;

//PORCENTAJE INDIVIDUAL
double porcentaje1 = (monto1 * 100)/capital;
double porcentaje2 = (monto2 * 100) / capital;
double porcentaje3 = (monto3 * 100) / capital;
 
Console.WriteLine("CAPITAL en $: " +capital);
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("PORCENATJE MONTO 1: " +porcentaje1+ "%");
Console.WriteLine("PORCENATJE MONTO 2: " + porcentaje2 + "%");
Console.WriteLine("PORCENATJE MONTO 3: " + porcentaje3 + "%");
