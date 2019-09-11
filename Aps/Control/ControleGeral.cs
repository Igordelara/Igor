using System;
using System.Collections.Generic;
using System.Text;

namespace Aps.Control
{
    class ControleGeral
    {

        public void adicionarPessoa()
        {
            Pessoa p = new Pessoa();
            Console.WriteLine("Informe cpf");
            p.Cpf = Console.ReadLine();
            Console.WriteLine("informe nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Informe usa idade: ");
            p.Idade = Convert.ToInt32(Console.ReadLine());
            Model.Listas.pessoaLista.Add(p);

        }

        public void pesquisarPorCpf()
        {
            Console.WriteLine("informe o cpf");
            string cpf = Console.ReadLine();
            Pessoa p = Model.Listas.pessoaLista.Find(x => x.Cpf.Equals(cpf));
            if (p != null)
            {
                Console.WriteLine(p.Nome);
                Console.WriteLine(p.Idade);
                Console.WriteLine(p.Cpf);
            }
            else
            {
                Console.WriteLine("cpf nao encontrado!");
            }

        }

        public void excluirPorCpf()
        {
            Console.WriteLine("informe o cpf para excluir");
            string cpf = Console.ReadLine();
            Pessoa p = Model.Listas.pessoaLista.Find(x => x.Cpf.Equals(cpf));
            if (p != null)
            {
                Model.Listas.pessoaLista.Remove(p);
                Console.WriteLine("removido com sucesso!");
            }
            else
            {
                Console.WriteLine("cpf nao encontrado!");
            }
        }

        public void alterarPorCpf()
        {
            Console.WriteLine("informe o cpf para alterar");
            string cpf = Console.ReadLine();
            Pessoa p = Model.Listas.pessoaLista.Find(x => x.Cpf.Equals(cpf));
            if (p != null)
            {
                Console.WriteLine("Digite o Novo Nome");
                p.Nome = Console.ReadLine();
                Console.WriteLine("Digite a nova Idade");
                p.Idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("cpf nao encontrado!");
            }
        }

        public void listarTodos()
        {
            foreach (Pessoa x in Model.Listas.pessoaLista)
            {
                Console.WriteLine("\n");
                Console.WriteLine(x.Cpf);
                Console.WriteLine(x.Nome);
                Console.WriteLine(x.Idade);
            }
        }


    }
}
