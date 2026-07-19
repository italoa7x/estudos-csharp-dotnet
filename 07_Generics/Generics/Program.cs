Console.WriteLine("### Generics ###");


var Value1 = new TesteClass();

Value1.Print("Ola");
Value1.Print(1);


class TesteClass
{
    public void Print<T>(T Prop)
    {
        System.Console.WriteLine($"O tipo do parametro é {Prop.GetType()}");
    }
}