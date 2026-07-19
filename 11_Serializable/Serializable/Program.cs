
using System.Text.Json;

string caminhoOrigem = @"C:\Users\darkc\Documents\curso_csharp\11_Serializable\Serializable\dados\aluno.json";

Console.WriteLine("### Serializable ###");

System.Console.WriteLine("Deserializando aluno");

string jsonContent = File.ReadAllText(caminhoOrigem);

var aluno = JsonSerializer.Deserialize<Aluno>(jsonContent);

Console.WriteLine($"Aluno deserializado {aluno.Nome} - {aluno.Id}");

public class Aluno
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public Aluno(int id, string nome)
    {
        Nome = nome;
        Id = id;
    }

    public Aluno(){}
}