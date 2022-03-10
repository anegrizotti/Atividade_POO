using System;

namespace Atividade_POO.ConsoleApp
{
    internal partial class Program
    {
        public class TestaFuncionario
        {
            static void Main(string[] args)
            {
                //02
                Funcionario funcionario_01 = new Funcionario();

                funcionario_01.nome = "Júlio Silva";
                funcionario_01.departamento = "Secretaria";
                funcionario_01.salario = 1000;
                funcionario_01.stringDataEntrada = "12/01/2022";
                funcionario_01.rg = "187382988";
                funcionario_01.estaNaEmpresa = true;

                funcionario_01.dataDeEntrada = new Data();

                funcionario_01.dataDeEntrada.dia = 12;
                funcionario_01.dataDeEntrada.mes = 01;
                funcionario_01.dataDeEntrada.ano = 2022;

                Console.WriteLine("Nome: " + funcionario_01.nome);
                Console.WriteLine("Departamento: " + funcionario_01.departamento);
                Console.WriteLine("Salario: " + funcionario_01.salario);
                Console.WriteLine("Data de entrada: " + funcionario_01.stringDataEntrada);
                Console.WriteLine("RG: " + funcionario_01.rg);
                Console.WriteLine("Esta na empresa: " + funcionario_01.estaNaEmpresa);
                Console.WriteLine();

                Console.WriteLine("Novo salário após bonificação: " + funcionario_01.Bonificar(100));
                Console.WriteLine();

                funcionario_01.Demitir();
                Console.WriteLine("Esta na empresa: " + funcionario_01.estaNaEmpresa);
                Console.WriteLine();

                funcionario_01.SeApresenta();
                Console.WriteLine();

                //03

                Console.WriteLine();
                funcionario_01.Mostar();
                Console.WriteLine();

                //04

                Funcionario funcionario_02 = new Funcionario();

                funcionario_02.nome = "Amanda Pereira";
                funcionario_02.departamento = "Secretaria";
                funcionario_02.salario = 1200;
                funcionario_02.stringDataEntrada = "05/10/2021";
                funcionario_02.rg = "389288828";
                funcionario_02.estaNaEmpresa = true;

                funcionario_02.dataDeEntrada = new Data();

                funcionario_01.dataDeEntrada.dia = 05;
                funcionario_01.dataDeEntrada.mes = 10;
                funcionario_01.dataDeEntrada.ano = 2021;

                if (funcionario_01 == funcionario_02)
                {
                    Console.WriteLine("Iguais!");
                } else
                {
                    Console.WriteLine("Diferentes!");
                }

                Console.WriteLine();



                //05

                Funcionario funcionario_03 = funcionario_02;

                if (funcionario_03 == funcionario_02)
                {
                    Console.WriteLine("Iguais!");
                }
                else
                {
                    Console.WriteLine("Diferentes!");
                }

                Console.WriteLine();



                //06

                Funcionario funcionario_04 = new Funcionario();

                funcionario_04.nome = "Felipe Rosa";
                funcionario_04.departamento = "Atendimento";
                funcionario_04.salario = 1500;
                funcionario_04.stringDataEntrada = "10/10/2010";
                funcionario_04.rg = "0404993939";
                funcionario_04.estaNaEmpresa = true;

                funcionario_04.dataDeEntrada = new Data();

                funcionario_04.dataDeEntrada.dia = 10;
                funcionario_04.dataDeEntrada.mes = 10;
                funcionario_04.dataDeEntrada.ano = 2010;


                //07

                // modificado
                funcionario_04.Mostar();


                //08

                // feito
            }
        }
    }
}
