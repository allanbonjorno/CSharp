using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NovaPasta
{
    public class Cliente
    {
        private string cpf;
        private float altura;
        private int idade;
        private string? nome;
        private string? sexo;
        public Cliente(string cpf, float altura, int idade, string nome, string sexo)
        {
            this.cpf = cpf;
            this.altura = altura;
            this.idade = idade;
            this.nome = nome;
            this.sexo = sexo;
        }

        public Cliente()
        {
        }

        public string getCpf() { return cpf; }
        public void setCpf(string cpf) { this.cpf = cpf; }
        public float getAltura() { return altura; }
        public void setAltura(float altura) { this.altura = altura; }
        public int getIdade() { return idade; }
        public void setIdade(int idade) { this.idade = idade; }
        public string getNome() { return nome; }
        public void setNome(string nome) { this.nome = nome; }
        public string getSexo() { return sexo; }
        public void setSexo(string sexo) { this.sexo = sexo; }

        
        
                 public void Visualizar()
        {
  
            
            Console.WriteLine($"Nome: {this.nome}         ");
            Console.WriteLine($"Gênero:{this.sexo}        ");
            Console.WriteLine($"CPF:{this.cpf}            ");
            Console.WriteLine($"Idade:{this.idade}        ");
            Console.WriteLine($"Altura: {this.altura}     ");

        }

            }

    }





