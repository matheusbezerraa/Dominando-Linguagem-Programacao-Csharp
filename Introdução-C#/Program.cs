using introdução_.net.Models;
//dotnet new console 
//dotnet build
//dotnet run
Pessoa p = new Pessoa();

p.Nome = "Matheus";
p.Idade = 20;
p.Apresentar();

Pessoa p2 = new Pessoa();

p2.Nome = "Lucas";
p2.Idade = 21;
p2.Apresentar();


DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

// cast - casting
int a = Convert.ToInt32("5");//string virou int
Console.WriteLine(a);

int b = int.Parse("15");// int para string
Console.WriteLine(b);

string x = "False";
Console.WriteLine(x);
Convert.ToBoolean(x);//convert consegue converter tds os valores
Console.WriteLine(x);

int inteiro = 5;
string y = inteiro.ToString();//para alterar pra sting

Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();// input do c#

switch(letra){
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Não é vogal");
        break;
}

Console.WriteLine("-------------------------------------");

Calculadora calcula = new Calculadora();

calcula.Somar(3,3);
calcula.Dividir(3,3);
calcula.Subtrair(3,3);
calcula.Multiplicar(3,3);
calcula.Potencia(3,3);
calcula.Seno(30);
calcula.Coseno(30);
calcula.Tangente(30);
calcula.RaizQuadrada(36);

Console.WriteLine("-------------------------------------");

Console.WriteLine("Digite um numero para tabuada: ");
string numeroString = Console.ReadLine();
int numeroInt = Convert.ToInt32(numeroString);

for(int contador = 1; contador<=10;contador++){
    Console.WriteLine($"{numeroInt} x {contador} = {numeroInt*contador}");
}

Console.WriteLine("-----------TABUADA WHILE--------------------------");

int contador2 = 1;
while (contador2 <= 10){
    Console.WriteLine($"{numeroInt} x {contador2} = {numeroInt*contador2}");
    contador2++;
}

int somei = 0;
int numerou = 0;

do{
    Console.WriteLine("Digite um número (0 para parar): ");
    numerou = Convert.ToInt32(Console.ReadLine());

    somei += numerou;

}while(numerou != 0);

Console.WriteLine($"O total da soma dos números acima foi {somei}");

string opcao;
bool exibirMenu = true;

while(exibirMenu){
    
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            //Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opção invalida");
            break;
    }
}