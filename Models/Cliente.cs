using System;

namespace ClientePad.api.Models
{
    
    public class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public double Salario { get; set; }
        public string Sexo { get; set; }

         public Cliente(int id, string nome, string cpf, DateTime dataNascimento, double salario, string sexo)
         {
            Id = id;
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Salario = salario;
            Sexo = sexo;

         }
    }
}

