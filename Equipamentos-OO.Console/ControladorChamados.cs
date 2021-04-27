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

        internal Chamado[] ArrayChamados { get => arrayChamados; set => arrayChamados = value; }
        public string[] NomesEquipamento { get => nomesEquipamento; set => nomesEquipamento = value; }
        public int[] Ids { get => ids; set => ids = value; }

        public string AdicionaNomeEquipamento(int idEquipamento, Equipamento [] equipamento, int [] idsEquipamento)
        {
            string nomeEquipamento = null;
            for(int i = 0; i<equipamento.Length; i++)
            {
                if(equipamento[i] != null)
                {
                    if(idEquipamento == idsEquipamento[i])
                    {
                        NomesEquipamento[i] = equipamento[i].Nome;
                        nomeEquipamento = NomesEquipamento[i];
                    }
                }
            }

            return nomeEquipamento;
        }

        public void InsereChamado(Chamado c)
        {
            ArrayChamados[cont] = c;
            Ids[cont] = id;
            cont++;
            id++;
        }

        public void VisualizaChamados()
        {
            Console.WriteLine("LISTA DOS CHAMADOS: ");
            Console.WriteLine("");
            for (int i = 0; i < ArrayChamados.Length; i++)
            {
                if (ArrayChamados[i] != null)
                {
                    Console.WriteLine("Id " + Ids[i] + "\n" + ArrayChamados[i]);
                    Console.WriteLine("----------------");
                }
            }
        }

        public void EditaChamado(int id, Chamado chamadoEditado)
        {
            for (int i = 0; i < ArrayChamados.Length; i++)
            {
                if (ArrayChamados[i] != null)
                {
                    if (Ids[i] == id)
                    {
                        //logic
                        ArrayChamados.SetValue(chamadoEditado, i);
                    }
                }
            }
        }

        public void ExcluiChamado(int id)
        {
            for (int i = 0; i < ArrayChamados.Length; i++)
            {
                if (ArrayChamados[i] != null)
                {
                    if (Ids[i] == id)
                    {
                        //logic
                        ArrayChamados = ArrayChamados.Where(val => val != ArrayChamados[i]).ToArray();
                        Ids = Ids.Where(val => val != Ids[i]).ToArray();
                    }
                }
            }
        }


    }
}
