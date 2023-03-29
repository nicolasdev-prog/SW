namespace Exercicio;
class Exemplo
{
public string nome="";

public int idade=0;

public bool vacinado=false;

//Métodos

public void mostramsg(){
    Console.WriteLine("oieeee 2F");
}

public void pegaNome(string texto){
    Console.WriteLine("Oieee:" + texto);
}

public string mensagem(){
    return"Devolvendo um texto";
}

public int somar(int a, int b){
    return a + b;
}


}
