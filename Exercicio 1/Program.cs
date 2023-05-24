namespace exercicio1;
class Program
{
    static void Main(string[] args)
    {
    Homem Thiago = new Homem();
    Cao Scooby = new Cao();
    Gato Ragnar = new Gato();

    Console.WriteLine(Thiago.Fala());
    Console.WriteLine(Scooby.Fala());
    Console.WriteLine(Ragnar.Fala());
    }   
        
}
