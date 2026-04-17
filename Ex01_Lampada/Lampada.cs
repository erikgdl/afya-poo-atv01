using System;

namespace Ex01_Lampada
{
    class Lampada
    {
        public string marca { get; }
        public string tecnologia { get; }
        public bool estado { get; private set; }
        public int brilho { get; private set; }

        public Lampada(string marca, string tecnologia)
        {
            this.marca = marca;
            this.tecnologia = tecnologia;
            estado = false;
            brilho = 100;
        }

        public void alternar()
        {
            estado = !estado;
        }

        public void ajustarBrilho(int novoBrilho)
        {
            try
            {
                if (novoBrilho < 0 || novoBrilho > 100)
                {
                    throw new ArgumentOutOfRangeException("O brilho deve estar entre 0 e 100.");
                }

                this.brilho = novoBrilho;
                Console.WriteLine($"Brilho ajustado para: {this.brilho}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Erro de validação: {ex.ParamName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu umm erro insperado: {ex.Message}");
            }
        }
    }

}