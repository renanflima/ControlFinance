using System;

List<Despesa> despesas = [];
List<Receita> receitas = [];

while (true)

{

    Console.WriteLine("===-===-===-===-===-===-===-===-===-===-===-===-");
    Console.WriteLine(" ");
    Console.WriteLine("                 CONTROL FINANCE                 ");
    Console.WriteLine(" ");
    Console.WriteLine("===-===-===-===-===-===-===-===-===-===-===-===-");

    Console.WriteLine(" ");

    Console.WriteLine("1 - Meu resumo financeiro");
    Console.WriteLine();

    Console.WriteLine("2 - Receitas");
    Console.WriteLine();

    Console.WriteLine("3 - Despesas");
    Console.WriteLine();

    Console.WriteLine("0 - Sair");
    Console.WriteLine();

    Console.WriteLine("Digite a opção desejada: ");

    Console.WriteLine();


    // Recebe a escolha

    string opcaoMenuPrincipal = Console.ReadLine();

    // Decide o que fazer com base na escolha do usuário

    switch (opcaoMenuPrincipal)
    {
        case "1":
            MenuResumoFinanceiro();
            break;
        case "2":
            MenuReceitas();
            break;
        case "3":
            MenuDespesas();
            break;
        case "0":
            Console.WriteLine("Saindo do programa...");
            return;
        default:
            Console.WriteLine("Opção inválida. Por favor, tente novamente.");
            break;
    }

}


// Função para mostrar o resumo financeiro
void MenuResumoFinanceiro()

{

    


    while (true)

    {

        Console.WriteLine("===-=== Resumo Financeiro ===-===");
        Console.WriteLine();
        Console.WriteLine("Aqui ficarão suas informações financeiras.");
        Console.WriteLine();

        decimal totalReceitas = CalcularTotalReceitas();
        decimal totalDespesas = CalcularTotalDespesas();
        decimal saldo = totalReceitas - totalDespesas;
        Console.WriteLine("Total de receitas: R$ " + totalReceitas.ToString("N2"));
        Console.WriteLine("===-========-===-===-===-===-===-===-===-");
        Console.WriteLine("Total de despesas: R$ " + totalDespesas.ToString("N2"));
        Console.WriteLine("===-========-===-===-===-===-===-===-===-");
        Console.WriteLine("Saldo atual: R$ " + saldo.ToString("N2"));
        Console.WriteLine("===-========-===-===-===-===-===-===-===-");

        Console.WriteLine();
        Console.WriteLine("0 - Voltar ao menu principal");

        string opcaoResumoFinanceiro = Console.ReadLine();

        switch (opcaoResumoFinanceiro)
        
        {

            case "0":
                Console.WriteLine("Voltando ao menu principal...");
                return;

            default:
                Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                break;

        }

    }

}

// Função para mostrar o menu de receitas

void MenuReceitas()

{
    while (true)

    {

        Console.WriteLine("===-=== Menu de Receitas ===-===");
        Console.WriteLine();
        Console.WriteLine("1 - Consultar receitas");
        Console.WriteLine("2 - Adicionar receita");
        Console.WriteLine("0 - Voltar ao menu principal");

        string opcaoReceita = Console.ReadLine();  

        switch (opcaoReceita)
        {

            case "1":

                if (receitas.Count == 0)

                    {
                    Console.WriteLine("Você não teve nenhuma receita adicional, vá trabalhar mais!!!");
                    Console.WriteLine();

                
                    }

                else

                    {

                    for (int i = 0; i < receitas.Count; i++)

                    {

                        Console.WriteLine("===-========-===-===-===-===-===-===-===-");
                        Console.WriteLine();
                        Console.WriteLine("Receita N° " + (i + 1));
                        Console.WriteLine();
                        Console.WriteLine("Descrição: " + receitas[i].Descricao);
                        Console.WriteLine();
                        Console.WriteLine("Valor: R$ " + receitas[i].Valor.ToString("N2"));
                        Console.WriteLine();
                        Console.WriteLine("===-========-===-===-===-===-===-===-===-");
                        Console.WriteLine();

                    }
                    }
                break;
            case "2":
                Receita novaReceita = new Receita();

                Console.WriteLine("Informe a descrição da receita: ");
                novaReceita.Descricao = Console.ReadLine() ?? "";

                Console.WriteLine("Informe o valor da receita:");
                novaReceita.Valor = decimal.Parse(Console.ReadLine() ?? "0");

                receitas.Add(novaReceita);

                Console.WriteLine("Receita cadastrada com sucesso!");
                break;
            case "0":
                Console.WriteLine("Voltando ao menu principal...");
                return;
            default:
                Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                break;
        }

    }
}

// Função para mostrar o menu de despesas

void MenuDespesas()
{
    
    

    while (true)

    {

        Console.WriteLine("===-=== Menu de Despesas ===-===");
        Console.WriteLine();
        Console.WriteLine("1 - Consultar despesas");
        Console.WriteLine("2 - Adicionar despesa");
        Console.WriteLine("0 - Voltar ao menu principal");

        string opcaoDespesas = Console.ReadLine();
        

        switch (opcaoDespesas)

        {

            case "1":


                if (despesas.Count == 0)
                {
                    Console.WriteLine("Nenhuma despesa encontrada");

                }

                else

                     {

                        decimal totalDespesas = CalcularTotalDespesas();

                    for (int i = 0; i < despesas.Count; i++)

                        {
                        
                        Console.WriteLine("===-========-===-===-===-===-===-===-===-");
                        Console.WriteLine();
                        Console.WriteLine("Despesa N° " + (i + 1));
                        Console.WriteLine();
                        Console.WriteLine("Descrição: " + despesas[i].Descricao);
                        Console.WriteLine();
                        Console.WriteLine("Valor: R$ " + despesas[i].Valor.ToString("N2"));
                        Console.WriteLine();
                        Console.WriteLine("Categoria: " + despesas[i].Categoria);
                        Console.WriteLine();
                        Console.WriteLine("===-========-===-===-===-===-===-===-===-");
                        Console.WriteLine();

                    }

                    Console.WriteLine("Total de despesas: R$ " + totalDespesas.ToString("N2"));

                }

                break;
            case "2":
                
                Despesa novaDespesa = new Despesa();

                Console.WriteLine("Informe a descrição da despesa: ");
                novaDespesa.Descricao = Console.ReadLine() ?? "";

               Console.WriteLine("Informe o valor da despesa:");
                novaDespesa.Valor = decimal.Parse(Console.ReadLine() ?? "0");

                Console.WriteLine("Informe a categoria da despesa: ");
                novaDespesa.Categoria = Console.ReadLine() ?? "";

                despesas.Add(novaDespesa);

                Console.WriteLine("Despesa cadastrada com sucesso!");

                break;


            case "0":
                Console.WriteLine("Voltando ao menu principal...");
                return;
            default:
                Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                break;
        }
    }




}

decimal CalcularTotalDespesas()

{
    decimal total = 0;

    for (int i = 0; i < despesas.Count; i++)

    {
        total += despesas[i].Valor;
    }

    return total;
}

decimal CalcularTotalReceitas()

{
    decimal total = 0;

    for (int i = 0; i < receitas.Count; i++)

    {
        total += receitas[i].Valor;
    }

    return total;
}
