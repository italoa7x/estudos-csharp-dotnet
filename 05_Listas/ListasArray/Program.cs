using System.Collections;

System.Console.WriteLine("### Listas com Array ###");


ArrayList lista = new(4);
lista.Add(1);
lista.Add(2);
lista.Add(3);

lista.Insert(0, 10);
for(int i = 0; i < lista.Count; i++)
{
    System.Console.WriteLine($"i = {lista[i]}");
}