using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades_Métodos_e_Construtores_com_C_.Models
{
    public class Curso
    {
        public string NomeDoCurso {get;set;}

        public List<Pessoa> Alunos{get;set;}

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int QuantidadeDeAlunosMatriculados(){
            int quantidade = Alunos.Count;
            Console.WriteLine("Quantidade de alunos matriculados no curso: "+quantidade);
            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno){
            Alunos.Remove(aluno);
        }

        public void ListarAlunos(){
            Console.WriteLine($"Alunos do curso de: {NomeDoCurso}");

            for(int count = 0; count < Alunos.Count; count++){
                string texto = $"N  {count+1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }

            //foreach (Pessoa aluno in Alunos)
            //{
            //    Console.WriteLine(aluno.NomeCompleto);   
            //}
        }
    }
}