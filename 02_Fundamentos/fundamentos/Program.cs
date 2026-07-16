Console.WriteLine("Variaveis numericas - inteiro");
Console.WriteLine();

byte valor1 = 255;
sbyte valor2 = -127;
int valor3 = -2147483647;
uint valor4 = 2147483647;
long valor5 = -21474836489;


Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);


int var1 = 8, var2 = 9, var3 = 10;
Console.WriteLine(var1);
Console.WriteLine(var2);
Console.WriteLine(var3);


Console.WriteLine("Variaveis numericas - ponto flutuante");

float f1 = 10.5F;
Console.WriteLine(f1);


Console.WriteLine("data / hora");

DateTime hoje = DateTime.Now;
Console.WriteLine($"Hoje: {hoje}");

Console.WriteLine("Apos inclução");
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddYears(1));


Console.WriteLine("Valores nullable");

Nullable<int> var1Nullable = null;
var1Nullable = 109;

Console.WriteLine(var1Nullable == null ? "Is null" : $"Contem valor {var1Nullable}");


int? var2Nullable = null;
var2Nullable = 15;

Console.WriteLine(var2Nullable == null ? "Is null" : $"Contem valor {2}");


string nome = "Maria";
int idade = 25;

Console.WriteLine($"{nome} tem {idade} anos\n");

Console.WriteLine("sequencia de escape\n");

string pizza = "Pizza de chocolate\nPizza tradicional";
string bolo = "\nBolo de chocolate\nbolo normal";

Console.WriteLine(pizza);
Console.WriteLine(bolo);



System.Console.WriteLine("conversao de dados\n");

int varInt = 100;
double varDouble = varInt;

System.Console.WriteLine(varInt.GetType());
System.Console.WriteLine(varDouble.GetType());

System.Console.WriteLine("conversao de dados");

int intIdade = 28;
string idadeString = Convert.ToString(intIdade);

System.Console.WriteLine($"idade {idade}");
System.Console.WriteLine($"idade string {idadeString}");
