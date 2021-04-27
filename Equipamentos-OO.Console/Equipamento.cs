using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipamentos_OO
{
    class Equipamento
    {
        private  string nome;
        private double precoAquisicao;
        private int numeroserie;
        private DateTime dataFabricacao;
        private string fabricante;

        public Equipamento(string nome, double precoAquisicao, int numeroserie, DateTime dataFabricacao, string fabricante)
        {
            this.nome = nome;
            this.precoAquisicao = precoAquisicao;
            this.numeroserie = numeroserie;
            this.dataFabricacao = dataFabricacao;
            this.fabricante = fabricante;
        }

        public string Nome { get => nome; set => nome = value; }
        public double PrecoAquisicao { get => precoAquisicao; set => precoAquisicao = value; }
        public int Numeroserie { get => numeroserie; set => numeroserie = value; }
        public DateTime DataFabricacao { get => dataFabricacao; set => dataFabricacao = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }

        public override string ToString()
        {
            return "Nome do equipamento: " + Nome + "\nPreço de aquisição: " + PrecoAquisicao + "\nNúmero de série: " + Numeroserie + "\nData de Fabricação: " + DataFabricacao.ToString("dd/MM/yyyy") + "\nFabricante: " + Fabricante;
        }
    }
}
