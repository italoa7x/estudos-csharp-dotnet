// Pessoa p1 = new("Maria");
// p1.Idade = 30;
// p1.Sexo = "feminino";

// p1.Comer();
// p1.Respirar();
// p1.Trabalhar();
// p1.SeApresentar();

var pessoa1 = new Pessoa2("Maria", 30, Sexo.MASCULINO);

pessoa1.Apresentar();

enum Sexo
{
    MASCULINO,
    FEMININO
}
struct Pessoa2
{
    public String? Nome;
    public int Idade;

    public Sexo Sexo;

    public Pessoa2(string? nome, int idade, Sexo sexo)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
    }

    public void Apresentar()
    {
        System.Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}\nSexo: {Sexo}");
    }
}


class Pessoa
{
    public string? Nome;
    public int Idade;
    public string? Sexo;

    public Pessoa(){}
    public Pessoa(string nome) => Nome = nome;

    public Pessoa(string nome, int idade, string sexo):this(nome)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
    } 

    public void Comer()
    {
        System.Console.WriteLine("Comendo...");
    }
    public void Respirar()
    {
        System.Console.WriteLine("Respirando...");
    }
    public void Trabalhar()
    {
        System.Console.WriteLine("Trabalhando...");
    }
    public void SeApresentar()
    {
        System.Console.WriteLine($"Olá,\nmeu nome é: {Nome}\neu tenho {Idade} anos\nE meu sexo é {Sexo}");
    }
}