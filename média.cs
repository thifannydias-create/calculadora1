using System;

class Program
{
    static void Main()
    {
    Console.WriteLine(&quot;=== Calculadora Escolar ===&quot;);
Console.Write(&quot;Digite a primeira nota: &quot;);
double nota1 = Convert.ToDouble(Console.ReadLine());
Console.Write(&quot;Digite a segunda nota: &quot;);
double nota2 = Convert.ToDouble(Console.ReadLine());
double soma = nota1 + nota2;
Console.WriteLine($&quot;Soma das notas: {soma}&quot;);
double media = soma / 2;
Console.WriteLine($&quot;Média: {media}&quot;);
if (media &gt;= 7)
{
Console.WriteLine(&quot;Aluno aprovado!&quot;);
}
else
{
Console.WriteLine(&quot;Aluno reprovado!&quot;);
}
    }
}
