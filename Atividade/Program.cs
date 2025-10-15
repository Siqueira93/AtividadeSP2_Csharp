using System;



namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informar nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Informar endereço");
            string endereco = Console.ReadLine();

            Console.WriteLine("Pessoa Física ou Jurídica? (f/j)");
            string tipo = Console.ReadLine();

            if (tipo == "f")
            {
                PessoaFisica pf = new PessoaFisica();
                pf.Nome = nome;
                pf.Eendereco = endereco;

                Console.WriteLine("Informar CPF");
                pf.CPF = Console.ReadLine();
                Console.WriteLine("Informar RG");
                pf.RG = Console.ReadLine();

                Console.WriteLine("Informar valor da compra");
                float valor = float.Parse(Console.ReadLine());

                pf.PagarImposto(valor);

                Console.WriteLine("Nome: " + pf.Nome);
                Console.WriteLine("Endereço: " + pf.Eendereco);
                Console.WriteLine("CPF: " + pf.CPF);
                Console.WriteLine("RG: " + pf.RG);
                Console.WriteLine("Valor: " + pf.Valor.ToString("C"));
                Console.WriteLine("Valor Imposto: " + pf.ValorImposto.ToString("C"));
                Console.WriteLine("Total: " + pf.Total.ToString("C"));


            }
            else if (tipo == "j")
            {
                PessoaJuridica pj = new PessoaJuridica();
                pj.Nome = nome;
                pj.Eendereco = endereco;

                Console.WriteLine("Informar CNPJ");
                pj.CNPJ = Console.ReadLine();
                Console.WriteLine("Informar IE");
                pj.IE = Console.ReadLine();

                Console.WriteLine("Informar valor da compra");
                float valor = float.Parse(Console.ReadLine());

                pj.PagarImposto(valor);

                Console.WriteLine("Nome: " + pj.Nome);
                Console.WriteLine("Endereço: " + pj.Eendereco); 
                Console.WriteLine("CNPJ: " + pj.CNPJ);
                Console.WriteLine("IE: " + pj.IE);
                Console.WriteLine("Valor: " + pj.Valor.ToString("C"));
                Console.WriteLine("Valor Imposto: " + pj.ValorImposto.ToString("C"));
                Console.WriteLine("Total: " + pj.Total.ToString("C"));
            }
            else
            {
                Console.WriteLine("Tipo inválido");
                return;
            }


        } 
        
    }
}