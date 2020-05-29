using System;

namespace Aula06Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            CNPJ gustavocnpj = new CNPJ();
            gustavocnpj.cnpj= "Gustavo";
            CPF gustavocpf = new CPF();
            gustavocpf.cpf= "Gustavo";
            gustavocpf.rg= "Gustavo";
            Pessoa gustavo = new Pessoa();
            gustavo.nome = "Gustavo";
            Console.WriteLine(gustavo.Saudar());

        }
    }
}
