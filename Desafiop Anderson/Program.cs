namespace DesafioAnderson;
class Program
{
        static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();


        Console.WriteLine("Introduza a primeira nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("primeira nota é: " + nota1);


        Console.WriteLine("Introduza a segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("segunda nota é: " + nota2);


        Console.WriteLine("Insira o nome do aluno: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("Qual é o nome " + nome);



        aluno1.nome = nome;
        aluno1.nota1 = nota1;
        aluno1.nota2 = nota2;

        aluno1.mensagem();
    }
}