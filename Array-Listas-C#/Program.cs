int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 30;
arrayInteiros[2] = 40;

for(int contador = 0; contador < arrayInteiros.Length; contador++){
    Console.WriteLine(contador+": "+ arrayInteiros[contador]);
}

int[] arrayInteirosDobrados = new int[arrayInteiros.Length*2];
Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);//copiando o array

arrayInteirosDobrados[5] = 100;

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);//pra alterar o tamnho depois do array

Console.WriteLine("----------------Alterei o tamanho------------------------------");

foreach (int valor in arrayInteiros)//não precisa de contador
{
    Console.WriteLine(valor);//pra colections usar foreach
}
Console.WriteLine("-----------------Copia-----------------------------");
foreach (int valor in arrayInteirosDobrados)//não precisa de contador
{
    Console.WriteLine(valor);//pra colections usar foreach
}

Console.WriteLine("USANDO LISTA");
List<string> listaString = new List<string>();

listaString.Add("Brasil");
listaString.Add("Argentina");
//listaString.Remove("Argentina");
listaString.Add("Chile");

foreach (string valor in listaString)
{
    Console.WriteLine("lista de paises: "+valor);
}