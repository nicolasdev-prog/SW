namespace ExerciciosAluno;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Aluno aluno1 =new Aluno();
        aluno1.nome= "Fulano da Silva";
        aluno1.nota1=4.3;
        aluno1.nota2=4;

        aluno1.mensagem();

    }
}
