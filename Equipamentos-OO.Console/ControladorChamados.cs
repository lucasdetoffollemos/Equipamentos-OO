using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipamentos_OO
{
    class ControladorChamados
    {
        private int id = 1;
        private int cont = 0;
        private Chamado[] arrayChamados = new Chamado[100];
        private string[] nomesEquipamento = new string[100];
        private int[] ids = new int[100];


        public string AdicionaNomeEquipamento(int idEquipamento, Equipamento [] equipamento, int [] idsEquipamento)
        {
            string nomeEquipamento = null;
            for(int i = 0; i<equipamento.Length; i++)
            {
                if(equipamento[i] != null)
                {
                    if(idEquipamento == idsEquipamento[i])
                    {
                        nomesEquipamento[i] = equipamento[i].Nome;
                        nomeEquipamento = nomesEquipamento[i];
                    }
                }
            }

            return nomeEquipamento;
        }

        public void InsereChamado(Chamado c)
        {
            arrayChamados[cont] = c;
            ids[cont] = id;
            cont++;
            id++;
        }

        public void VisualizaChamados()
        {
            Console.WriteLine("LISTA DOS CHAMADOS: ");
            Console.WriteLine("");
            for (int i = 0; i < arrayChamados.Length; i++)
            {
                if (arrayChamados[i] != null)
                {
                    Console.WriteLine("Id " + ids[i] + "\n" + arrayChamados[i]);
                    Console.WriteLine("----------------");
                }
            }
        }

        public void EditaChamado(int id, Chamado chamadoEditado)
        {
            for (int i = 0; i < arrayChamados.Length; i++)
            {
                if (arrayChamados[i] != null)
                {
                    if (ids[i] == id)
                    {
                        //logic
                        arrayChamados.SetValue(chamadoEditado, i);
                    }
                }
            }
        }

        public void ExcluiChamado(int id)
        {
            for (int i = 0; i < arrayChamados.Length; i++)
            {
                if (arrayChamados[i] != null)
                {
                    if (ids[i] == id)
                    {
                        //logic
                        arrayChamados = arrayChamados.Where(val => val != arrayChamados[i]).ToArray();
                        ids = ids.Where(val => val != ids[i]).ToArray();
                    }
                }
            }
        }


    }
}
