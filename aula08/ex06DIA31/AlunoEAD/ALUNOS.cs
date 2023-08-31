using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06DIA31.AlunoEAD
{
    internal class ALUNOS
    {
        private string nome;
        private string cpf;
        private int idade;
        private string? sexo;
        private int matricula;
        public ALUNOS(string nome, string cpf, int idade, string sexo, int matricula)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
            this.sexo = sexo;
            this.matricula = matricula;
        }

        public ALUNOS()
        {
        }

        public string getNome() { return nome; }
        public void setNome(string nome) { this.nome = nome; }
        public string getCpf() { return cpf; }
        public void setCpf(string cpf) { this.cpf = cpf; }
        public int getIdade() { return idade; }
        public void setIdade(int idade) { this.idade = idade; }
        public string getSexo() { return sexo; }
        public void setSexo(string sexo) { this.sexo = sexo; }
        public int getMatricula() { return matricula; }
        public void setMatricula(int matricula) { this.matricula = matricula; }



        public void Visualizar()
        {

             
            Console.WriteLine($"Nome: {this.nome}               ");
            Console.WriteLine($"CPF:{this.cpf}                  ");
            Console.WriteLine($"Gênero:{this.sexo}              ");
            Console.WriteLine($"Idade:{this.idade}              ");
            Console.WriteLine($"Matricula: {this.matricula}     ");

        }
    }
}
