using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipamentos_OO
{
    class Chamado
    {

        private string tituloChamado;
        private string descricaoChamado;
        private string equipamento;
        private DateTime dataAbertura;
        private int diasEmAberto;

        public Chamado(string tituloChamado, string descricaoChamado, string equipamento, DateTime dataAabertura)
        {
            this.TituloChamado = tituloChamado;
            this.DescricaoChamado = descricaoChamado;
            this.Equipamento = equipamento;
            this.DataAabertura = dataAabertura;
        }

        public string TituloChamado { get => tituloChamado; set => tituloChamado = value; }
        public string DescricaoChamado { get => descricaoChamado; set => descricaoChamado = value; }
        public string Equipamento { get => equipamento; set => equipamento = value; }
        public DateTime DataAabertura { get => dataAbertura; set => dataAbertura = value; }

        public int DataEmAberto()
        {

            DateTime dataAtual = DateTime.Now;

            TimeSpan diferenca = dataAtual.Subtract(DataAabertura);

            diasEmAberto = Convert.ToInt32(diferenca.TotalDays);

            return diasEmAberto - 1;

        }

        public override string ToString()
        {
            return "Título chamado: " + TituloChamado + "\nDescrição chamado: " + DescricaoChamado + "\nEquipamento: " + Equipamento + "\nData de Fabricação: " + DataAabertura.ToString("dd/MM/yyyy") + "\nNúmero de dias em aberto: " + DataEmAberto();
        }
    }
}
