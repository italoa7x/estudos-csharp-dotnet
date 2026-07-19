Console.WriteLine("### Excecoes ###");

try
{
    A.ProcessarA();
}catch
{
    System.Console.WriteLine("Erro tratado na main");
}


class A
{
    public static void ProcessarA()
    {
        B.ProcessarB();
    }
}

class B
{
    public static void ProcessarB()
    {
        C.ProcessarC();
    }
}

class C
{
    public static void ProcessarC()
    {
        throw new MinhaExcecaoException("Metodo nao implementado");
    }
}


public class MinhaExcecaoException : Exception
{
    public MinhaExcecaoException()
    {}

    public MinhaExcecaoException(string message):base(message)
    {}

    public MinhaExcecaoException(string message, Exception inner):base(message, inner)
    {}
}