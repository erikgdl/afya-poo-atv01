using System;

namespace Ex02_Cofre;

class Program
{
    static void Main(string[] args)
    {
        string? name, password, newPassword, fechar;

        Console.WriteLine("Digite o nome do dono do cofre:");
        name = Console.ReadLine();
        Console.WriteLine("Digite a senha do cofre:");
        password = Console.ReadLine();

        var cofre = new Cofre(name, password);

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n=== MENU DO COFRE ===");
            Console.WriteLine("1. Abrir cofre");
            Console.WriteLine("2. Fechar cofre");
            Console.WriteLine("3. Alterar senha");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");

            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a senha: ");
                    string? senhaAbrir = Console.ReadLine();
                    cofre.abrir(senhaAbrir);
                    break;

                case "2":
                    cofre.fechar();
                    break;

                case "3":
                    Console.Write("Digite a senha atual: ");
                    string? senhaAtual = Console.ReadLine();
                    Console.Write("Digite a nova senha: ");
                    string? novaSenha = Console.ReadLine();
                    cofre.alterarSenha(senhaAtual, novaSenha);
                    break;

                case "4":
                    continuar = false;
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            if (cofre.contadorTentativas == 0)
            {
                break;
            }
        }

    }
}