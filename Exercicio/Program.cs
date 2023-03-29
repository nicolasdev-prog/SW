namespace Exercicio;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.ReadKey();

        //Criar Uma Instância(objeto)a partir de uma classe
        Exemplo exe01 = new Exemplo();


        exe01.mostramsg();

        exe01.pegaNome("Nicolas");

        Console.WriteLine(exe01.mensagem());
        
        Console.WriteLine("O resultado da soma é:" + exe01.somar(10,20));
    }
}
