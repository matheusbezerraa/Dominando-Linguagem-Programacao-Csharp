using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades_Métodos_e_Construtores_com_C_.Models
{
    public class Pessoa
    {
        public Pessoa(){//constrtutor

        }
        public Pessoa(string nome, string sobrenome){//construtor
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private int _idade;

        private string _sobrenome;

        public string Nome { 
            get => _nome.ToUpper();//(Deixa o nome todo maiusculo)body expressions
            
            set{
                if(value ==""){
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome{
            get => _sobrenome.ToUpper();

            set{
                if(value ==""){
                    throw new ArgumentException("O sobrenome não pode ser vazio");
                }

                _sobrenome = value;
            }     
        }

        public string NomeCompleto {
             get => $"{Nome} {Sobrenome}"; 
        }

        public int Idade {
            get => _idade;//body expressions
            set{
                if(value<0){
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            } 
        }

        public void Apresentar(){
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}