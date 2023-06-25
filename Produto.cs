using System.Globalization;

using System.Threading.Channels;

namespace Exercicios004
{
    class Produto
    {
        public string Nome { get; set; }
        public  double Preco { get; set; }
        public int Quantidade { get; set; }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicianarProdutos(int howMuch)
        {
            Quantidade += howMuch;
        }

        public void RemoverProdutos(int howMuch)
        {
            Quantidade -= howMuch;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }


}
