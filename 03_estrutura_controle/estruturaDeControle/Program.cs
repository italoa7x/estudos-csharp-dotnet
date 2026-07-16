// Console.Write("Informe a nota do aluno \t");
// var nota = Convert.ToDouble(Console.ReadLine());

// if(nota < 5)
// {
//     System.Console.WriteLine("Aluno reprovado");
// }
// else if(nota >= 5 && nota < 6)
// {
//     System.Console.WriteLine("Aluno em recuperação");
// }
// else if(nota >= 6 && nota <= 9)
// {
//     System.Console.WriteLine("Aluno aprovado");
// }
// else
// {
//     System.Console.WriteLine("Aluno aprova com distincao");
// }

System.Console.WriteLine("instruções de repetição");

System.Console.Write("informe um número: ");
int numero = Convert.ToInt16(Console.ReadLine());

if(numero == 0)
{
    System.Console.WriteLine("Informe um número maior que 0");
}
else
{
    System.Console.WriteLine($"Tabuada do {numero}");
    int contador = 1;
    while(contador < 11)
    {
        System.Console.WriteLine($"{contador} x {numero} = {contador * numero}");
        contador++;
    }
} 