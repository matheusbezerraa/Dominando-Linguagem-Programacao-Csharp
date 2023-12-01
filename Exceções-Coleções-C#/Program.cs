
using Exceções_Coleções_C_.Models;

try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach(string linha in linhas){
        Console.WriteLine(linha);
    }

}catch(FileNotFoundException ex){
    Console.WriteLine("Ocorreu um erro na leitura do arquivo, Arquivo não encontrado "+ex.Message);
}

catch(DirectoryNotFoundException ex){
    Console.WriteLine("Ocorreu um erro na leitura do arquivo, Caminho não encontrado "+ex.Message);//tratamento de erros para continuar o codigo
}

catch(Exception ex){
    Console.WriteLine("Ocorreu uma exceção generica "+ex.Message);//tratamento de erros para continuar o codigo
}

finally{
    Console.WriteLine("Operação concluida com sucesso");
}



//ESTUDANDO FILA----------------------FirstInLastOut----------------
Console.WriteLine($"FILA");
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(20);
fila.Enqueue(55);

foreach(int item in fila){
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo elemento: {fila.Dequeue()}");
fila.Enqueue(67);

foreach(int item in fila){
    Console.WriteLine(item);
}

//ESTUDANDO PILHA---------LastInFirstOut-------------------------------------------
Console.WriteLine($"PILHA");
Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(3);
pilha.Push(20);
pilha.Push(55);

foreach(int i in pilha){
    Console.WriteLine(i);
}

Console.WriteLine($"Removendo elemento: {pilha.Pop()}");
pilha.Push(67);

foreach(int i in pilha){
    Console.WriteLine(i);
}

//--------------------------------------------------------------------------------------
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("PE", "Pernambuco");
estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("BA", "Pernambuco");//só pode repetir o value, a key não pode

Console.WriteLine(estados["PE"]);//Para acessar um value 

foreach(var item in estados){//resumido
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados["BA"] = "Bahia - valor alterado";

Console.WriteLine("---------------------------------");

foreach(var item in estados){//resumido
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("RJ");

Console.WriteLine("---------------------------------");

foreach(var item in estados){//resumido
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string verificandoChave = "RJ";
Console.WriteLine($"Verificando o elemento: {verificandoChave}");

if(estados.ContainsKey(verificandoChave)){
    Console.WriteLine($"Valor existente: {verificandoChave}");
}else{
    Console.WriteLine($"Valor não existe, pode adicionar: {verificandoChave}");
}

new ExemploExcecao().Metodo1();