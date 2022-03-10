using System;

namespace Atividade_POO.ConsoleApp
{
    internal partial class Program
    {
        public class Funcionario
        {
            public string nome;
            public string departamento;
            public double salario;
            public string stringDataEntrada;
            public string rg;
            public bool estaNaEmpresa;

            public Data dataDeEntrada;

            public double Bonificar(double valorBonificacao)
            {
                salario = salario + valorBonificacao;

                return salario;
            }

            public void Demitir()
            {
                estaNaEmpresa = false;
            }

            public void SeApresenta()
            {
                Console.Write("Olá. Meu nome é " + nome + " e eu trabalho no departamento " + departamento +". Se precisar" +
                    "da minha ajuda, estarei a disposição!");
            }

            public void Mostar()
            {
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Departamento: " + departamento);
                Console.WriteLine("Salario: " + salario);
                //Console.WriteLine("Data de entrada: " + stringDataEntrada);
                Console.WriteLine("Data de entrada: " + dataDeEntrada.dia+"/"+dataDeEntrada.mes+"/"+dataDeEntrada.ano);
                Console.WriteLine("RG: " + rg);
                Console.WriteLine("Esta na empresa: " + estaNaEmpresa);
            }

        }

    }
}
