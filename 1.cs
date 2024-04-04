using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<string> listaDeCompras = new List<string>();
        int Opcao;
        Boolean Sair = false; 
        while (!Sair) {
            Console.WriteLine("Seja bem vindo! Selecione a opção desejada:");
            Console.WriteLine("1- Criar lista de compras");
            Console.WriteLine("2- Mostrar lista de compras");
            Console.WriteLine("3- Sair");
            Opcao = Convert.ToInt32(Console.ReadLine());
            switch (Opcao)
            {
                case 1:
                    CriarListadeCompras(listaDeCompras);
                    SalvarListaDeCompras(listaDeCompras, "ListadeCompras.txt");
                    break;
                case 2:
                    ListarItens(listaDeCompras);
                    break;
                case 3:
                    Sair = true;
                    break;
            }
           }
    }


    static void CriarListadeCompras(List<string> lista) {
        Boolean Parar = false;
        int Opcao;
        while (!Parar)
        {
            Console.WriteLine("Adicione o produto na sua lista de compras:");
            lista.Add(Console.ReadLine());
            Console.WriteLine("Deseja adicionar outro item ?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Opcao = Convert.ToInt32(Console.ReadLine()); 
            if (Opcao == 2) {
                Parar = true;
            }
        }
    }



    static void ListarItens(List<string> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
    }

    static void SalvarListaDeCompras(List<string> lista, string nomeArquivo)
    {
        try
        {
            using (StreamWriter arquivo = new StreamWriter(nomeArquivo))
            {
                foreach (var item in lista)
                {
                    arquivo.WriteLine(item);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocorreu um erro ao salvar a lista de compras: " + ex.Message);
        }
    }
}
