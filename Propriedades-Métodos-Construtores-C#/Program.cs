using System.Globalization;
using Propriedades_Métodos_e_Construtores_com_C_.Models;

//Pessoa p1 = new Pessoa();
//p1.Nome = "Matheus";
//p1.Sobrenome = "Bezerra";
//p1.Idade = 20;
//p1.Apresentar();

Pessoa p1 = new Pessoa(nome:"Matheus",sobrenome:"Bezerra");
//p1.Nome = "Matheus";
//p1.Sobrenome = "Bezerra";

Pessoa p2 = new Pessoa(nome:"Gabriel",sobrenome:"Silva");
//p2.Nome = "Gabriel";
//p2.Sobrenome = "Silva";

Curso cursoDeIngles = new Curso();
cursoDeIngles.NomeDoCurso = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
cursoDeIngles.QuantidadeDeAlunosMatriculados();

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");//pra escolher o lugar da moeda

decimal valorMonetario = 82.40M;
Console.WriteLine($"{valorMonetario:C}");//adiciona de acordo com o seu sistema

Console.WriteLine(valorMonetario.ToString("C5", CultureInfo.CreateSpecificCulture("pt-BR")));

double porcentagem=.3421;
Console.WriteLine(porcentagem.ToString("P"));

