using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipamentos_OO
{
    class Menus
    {
        private string opcao;

        public string MenuPrincipal()
        {
            Console.WriteLine("Digite 1 para ir aos equipamentos: ");
            Console.WriteLine("Digite 2 para ir aos chamados: ");
            Console.WriteLine("Digite s para sair: ");
            opcao = Console.ReadLine();
            return opcao;
        }

        public string MenuEquipamentos()
        {
            Console.WriteLine("Digite 1 para registrar equipamento: ");
            Console.WriteLine("Digite 2 para visualizar equipamento: ");
            Console.WriteLine("Digite 3 para editar equipamento: ");
            Console.WriteLine("Digite 4 para excluir equipamento: ");

            opcao = Console.ReadLine();
            return opcao;
        }

        public string MenuChamados()
        {
            //Menu chamados
            Console.WriteLine("Digite 1 para registrar chamado: ");
            Console.WriteLine("Digite 2 para visualizar chamado: ");
            Console.WriteLine("Digite 3 para editar chamado: ");
            Console.WriteLine("Digite 4 para excluir chamado: ");

            opcao = Console.ReadLine();
            return opcao;
        }
    }
}
