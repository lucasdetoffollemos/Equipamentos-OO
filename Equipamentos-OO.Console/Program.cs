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

            
            string nome, fabricante;
            double precoAquisicao;
            int nSerie;
            DateTime dataFabricacao;
            string nomeEquipamento = " ";

            ControladorEquipamentos controladorEquipamentos = new ControladorEquipamentos();
            ControladorChamados controladorChamados = new ControladorChamados();

            while (true)
            {

                //Menu principal
                Console.WriteLine("Digite 1 para ir aos equipamentos: ");
                Console.WriteLine("Digite 2 para ir aos chamados: ");
                Console.WriteLine("Digite s para sair: ");
                string opcao = Console.ReadLine();

                Console.Clear();

                if(opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                switch (opcao)
                {
                    case "1":
                        //Menu equipamentos
                        Console.WriteLine("Digite 1 para registrar equipamento: ");
                        Console.WriteLine("Digite 2 para visualizar equipamento: ");
                        Console.WriteLine("Digite 3 para editar equipamento: ");
                        Console.WriteLine("Digite 4 para excluir equipamento: ");

                        string opcaoEqui = Console.ReadLine();
                        Console.Clear();


                        switch (opcaoEqui)
                        {
                            case "1":
                                Console.WriteLine("Digite o nome do equipmaneto: ");
                                nome = Console.ReadLine();

                                while (nome.Length < 6)
                                {
                                    Console.WriteLine("Nome inválido, digite novamente, no minimo 6 caracteres.");
                                    Console.WriteLine("Insira o nome do equipamento: ");
                                    nome = Console.ReadLine();
                                }

                                Console.WriteLine("Digite o preço de aquisição do equipamento: ");
                                precoAquisicao = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Digite o número de série do equipamento: ");
                                nSerie = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Digite a data de fabricaçao do equipamento no formato dd/MM/yyyy: ");
                                dataFabricacao = Convert.ToDateTime(Console.ReadLine());

                                Console.WriteLine("Digite o fabricante do equipamento: ");
                                fabricante = Console.ReadLine();

                                Equipamento equipamento = new Equipamento(nome, precoAquisicao, nSerie, dataFabricacao, fabricante);
                                controladorEquipamentos.InsereEquipamnetos(equipamento);

                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "2":
                                controladorEquipamentos.VisualizaEquipamnetos();
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "3":
                                controladorEquipamentos.VisualizaEquipamnetos();

                                Console.WriteLine("Digite o id do equipamento que deseja editar: ");
                                int idEditar = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();

                                Console.WriteLine("Insira o nome do equipamento: ");
                                string nomeEditado = Console.ReadLine();

                                while (nomeEditado.Length < 6)
                                {
                                    Console.WriteLine("Nome inválido, digite novamente, no minimo 6 caracteres.");
                                    Console.WriteLine("Insira o nome do equipamento: ");
                                    nomeEditado = Console.ReadLine();
                                }

                                Console.WriteLine("Insira o preço de aquisição: ");
                                double precoAquisicaoEditado = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Insira o número de série: ");
                                int nSerieEditado = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Insira a data: ");
                                DateTime dataFabricacaoEditado = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("Insira o fabricante: ");
                                string fabricanteEditado = Console.ReadLine();

                                Equipamento eEditado = new Equipamento(nomeEditado, precoAquisicaoEditado, nSerieEditado, dataFabricacaoEditado, fabricanteEditado);

                                controladorEquipamentos.EditarEquipamentos(idEditar, eEditado);
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "4":
                                controladorEquipamentos.VisualizaEquipamnetos();

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
                        //Menu chamados
                        Console.WriteLine("Digite 1 para registrar chamado: ");
                        Console.WriteLine("Digite 2 para visualizar chamado: ");
                        Console.WriteLine("Digite 3 para editar chamado: ");
                        Console.WriteLine("Digite 4 para excluir chamado: ");

                        string opcaoChamado = Console.ReadLine();
                        Console.Clear();

                        switch (opcaoChamado)
                        {
                            case "1":
                                controladorEquipamentos.VisualizaEquipamnetos();

                                Console.WriteLine("Digite o id do equipamento que deseja realizar o chamado: ");
                                int idEquipamentoChamado = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();

                                nomeEquipamento = controladorChamados.AdicionaNomeEquipamento(idEquipamentoChamado, controladorEquipamentos.ArrayEquipamentos, controladorEquipamentos.Ids);

                                Console.WriteLine("Insira o titulo do chamado: ");
                                string tituloChamado = Console.ReadLine();

                                Console.WriteLine("Insira a descrição do chamado: ");
                                string descricaoChamado = Console.ReadLine();

                                Console.WriteLine("Digite a data de abertura do chamado no formato dd/MM/yyyy: ");
                                dataFabricacao = Convert.ToDateTime(Console.ReadLine());

                                Chamado chamado = new Chamado(tituloChamado, descricaoChamado, nomeEquipamento, dataFabricacao);
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

                                

                                Console.WriteLine("EDITAR CHAMADO: ");
                                Console.WriteLine("Titulo do chamado: ");
                                string tituloChamadoEditado = Console.ReadLine();
                                Console.WriteLine("Descrição do chamado: ");
                                string descricaoChamadoEditado = Console.ReadLine();
                                Console.WriteLine("Data de abertura do chamado: ");
                                DateTime dataChamadoEditado = Convert.ToDateTime(Console.ReadLine());
                                Console.Clear();

                                Chamado chamadoEditado = new Chamado(tituloChamadoEditado, descricaoChamadoEditado, nomeEquipamento, dataChamadoEditado);

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
