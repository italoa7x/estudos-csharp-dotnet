System.Console.WriteLine("### Classes ###\n");

var funcionario1 = new Funcionario();
funcionario1.Nome = "Italo";
funcionario1.ExibeNome();

class Pessoa
{
    public string? Nome { get; set; }
    public virtual void ExibeNome()
    {
        System.Console.WriteLine($"Ola, meu nome é {Nome}, eu osu uma pessoa");
    }
}

class Funcionario : Pessoa
{
    
    public override void ExibeNome()
    {
        System.Console.WriteLine($"Ola, meu nome é {Nome}, eu sou um funcionario");
    }
}