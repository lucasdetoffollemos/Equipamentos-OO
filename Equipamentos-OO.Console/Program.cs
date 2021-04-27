using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipamentos_OO
{
    class Program
    {
        static void Main(string[] args)
        {

            double precoAquisicao, precoAquisicaoEditado;
            int nSerie, nSerieEditado;
            DateTime dataFabricacao, dataFabricacaoEditado, dataAbertura, dataAberturaEditado;
            string fabricante, fabricanteEditado, tituloChamado, descricaoChamado, tituloChamadoEditado, descricaoChamadoEditado;

            //nome que será utilizado, tanto na criaçao do chamado, quanto na edição do chamado
            string nomeEquipamento = " ";

            //objetos
            ControladorEquipamentos controladorEquipamentos = new ControladorEquipamentos();
            ControladorChamados controladorChamados = new ControladorChamados();
            Menus menu = new Menus();
            Validadora valida = new Validadora();
            while (true)
            {
                //Menu principal
                string opcao = menu.MenuPrincipal();
                Console.Clear();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                switch (opcao)
                {
                    case "1":
                        //Menu equipamentos
                        string opcaoEqui = menu.MenuEquipamentos();
                        Console.Clear();

                        switch (opcaoEqui)
                        {
                            case "1":
                                string nome = valida.ValidaNomeEquipamento();

                                valida.RegistroInformacoesEqui(out precoAquisicao, out nSerie, out dataFabricacao, out fabricante);

                                Equipamento equipamento = new Equipamento(nome, precoAquisicao, nSerie, dataFabricacao, fabricante);
                                controladorEquipamentos.InsereEquipamentos(equipamento);

                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "2":

                                controladorEquipamentos.VisualizaEquipamentos();
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "3":
                                controladorEquipamentos.VisualizaEquipamentos();

                                Console.WriteLine("Digite o id do equipamento que deseja editar: ");
                                int idEditar = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();

                                string nomeEditado = valida.ValidaNomeEquipamento();

                                valida.RegistroInformacoesEqui(out precoAquisicaoEditado, out nSerieEditado, out dataFabricacaoEditado, out fabricanteEditado);

                                Equipamento eEditado = new Equipamento(nomeEditado, precoAquisicaoEditado, nSerieEditado, dataFabricacaoEditado, fabricanteEditado);
                                controladorEquipamentos.EditarEquipamentos(idEditar, eEditado);

                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "4":
                                controladorEquipamentos.VisualizaEquipamentos();

                                Console.WriteLine("Digite o id do equipamento que deseja excluir: ");
                                int idExcluir = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();

                                controladorEquipamentos.ExcluirEquipamentos(idExcluir);
                                Console.ReadLine();
                                Console.Clear();
                                break;
                        }

                        break;

                    case "2":
                        string opcaoChamado = menu.MenuChamados();
                        Console.Clear();

                        switch (opcaoChamado)
                        {
                            case "1":
                                controladorEquipamentos.VisualizaEquipamentos();

                                Console.WriteLine("Digite o id do equipamento que deseja realizar o chamado: ");
                                int idEquipamentoChamado = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();

                                nomeEquipamento = controladorChamados.AdicionaNomeEquipamento(idEquipamentoChamado, controladorEquipamentos.ArrayEquipamentos, controladorEquipamentos.Ids);

                               

                                valida.RegistroInformacoesChamado(out tituloChamado, out descricaoChamado, out dataAbertura);

                                Chamado chamado = new Chamado(tituloChamado, descricaoChamado, nomeEquipamento, dataAbertura);
                                controladorChamados.InsereChamado(chamado);

                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "2":
                                controladorChamados.VisualizaChamados();
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "3":
                                controladorChamados.VisualizaChamados();

                                Console.WriteLine("Digite o id do chamado que deseja editar: ");
                                int idEditar = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();

                                valida.RegistroInformacoesChamado(out tituloChamadoEditado, out descricaoChamadoEditado, out dataAberturaEditado);

                                Console.Clear();

                                Chamado chamadoEditado = new Chamado(tituloChamadoEditado, descricaoChamadoEditado, nomeEquipamento, dataAberturaEditado);
                                controladorChamados.EditaChamado(idEditar, chamadoEditado);

                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "4":
                                controladorChamados.VisualizaChamados();

                                Console.WriteLine("Digite o id do chamado que deseja excluir: ");
                                int idExcluir = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();

                                controladorChamados.ExcluiChamado(idExcluir);
                                Console.ReadLine();
                                Console.Clear();
                                break;
                        }

                        break;
                }
            }
        }
    }
}
