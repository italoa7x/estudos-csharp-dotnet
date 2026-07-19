Console.WriteLine("### Programação assincrona ###");

await ClasseAssincrona.MeuMetodoAsync();

public abstract class ClasseAssincrona()
{
    public static async Task<int> MeuMetodoAsync()
    {
        System.Console.WriteLine("Iniciando processamento...");
        await Task.Delay(1000);
        System.Console.WriteLine("A operação assincrona foi concluida");
        return 1;
    }
}