using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipamentos_OO
{
    class Validadora
    {

        public string ValidaNomeEquipamento()
        {
            Console.WriteLine("Digite o nome do equipmaneto: ");
            string nome = Console.ReadLine();

            while (nome.Length < 6)
            {
                Console.WriteLine("Nome inválido, digite novamente, no minimo 6 caracteres.");
                Console.WriteLine("Insira o nome do equipamento: ");
                nome = Console.ReadLine();
            }

            return nome;
        }

        public void RegistroInformacoesEqui(out double precoAquisicao, out int nSerie, out DateTime dataFabricacao, out string fabricante)
        {
            Console.WriteLine("Digite o preço de aquisição do equipamento: ");
            precoAquisicao = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o número de série do equipamento: ");
            nSerie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a data de fabricaçao do equipamento no formato dd/MM/yyyy: ");
            dataFabricacao = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite o fabricante do equipamento: ");
            fabricante = Console.ReadLine();
        }

        public void RegistroInformacoesChamado(out string tituloChamado, out string descricaoChamado, out DateTime dataAbertura)
        {
            Console.WriteLine("Insira o titulo do chamado: ");
            tituloChamado = Console.ReadLine();
            Console.WriteLine("Insira a descrição do chamado: ");
            descricaoChamado = Console.ReadLine();
            Console.WriteLine("Digite a data de abertura do chamado no formato dd/MM/yyyy: ");
            dataAbertura = Convert.ToDateTime(Console.ReadLine());
        }
    }
}
