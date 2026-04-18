using System;

namespace Ex02_Cofre;

class Cofre
{
    public string? dono { get; }
    public string? senha { get; private set; }
    public bool estaAberto { get; private set; }
    public int contadorTentativas { get; private set; }

    public Cofre(string dono, string senha)
    {
        this.dono = dono;
        this.senha = senha;
        this.contadorTentativas = 3;
        this.estaAberto = false;
    }

    public void abrir(string senhaInformada)
    {

        if (senha == senhaInformada)
        {
            Console.WriteLine("Cofre aberto com sucesso!");
            estaAberto = !estaAberto;
        }
        else
        {
            contadorTentativas--;
            Console.WriteLine($"Senha incorreta. Acesso negado. Tentativas restantes: {contadorTentativas}");
        }

    }

    public void fechar()
    {
        if (estaAberto)
        {
            Console.WriteLine("está fechando o cofre...");
            estaAberto = !estaAberto;
        }
    }

    public void alterarSenha(string senhaAtual, string novaSenha)
    {
        if (estaAberto && senha == senhaAtual)
        {
            senha = novaSenha;
            Console.WriteLine("Senha alterada com sucesso!");
        }
        else
        {
            Console.WriteLine("Senha incorreta.....");
        }
    }

}