using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipamentos_OO
{
    class ControladorEquipamentos
    {
        private int id = 1;
        private int cont = 0;
        private Equipamento[] arrayEquipamentos = new Equipamento[100];
        private int [] ids = new int[99];

        public Equipamento[] ArrayEquipamentos { get => arrayEquipamentos; set => arrayEquipamentos = value; }
        public int[] Ids { get => ids; set => ids = value; }

        public void InsereEquipamnetos(Equipamento e)
        {
            ArrayEquipamentos[cont] = e;
            Ids[cont] = id;
            cont++;
            id++;
            
        }
        public void VisualizaEquipamnetos()
        {
            Console.WriteLine("LISTA DOS EQUIPAMENTOS: ");
            Console.WriteLine("");
            for (int i = 0; i < ArrayEquipamentos.Length; i++)
            {
                if(ArrayEquipamentos[i] != null)
                {
                    Console.WriteLine("Id " + Ids[i] + "\n" + ArrayEquipamentos[i]);
                    Console.WriteLine("----------------");
                }
            }
        }

        public void EditarEquipamentos(int id, Equipamento eEditado)
        {
            for (int i = 0; i < ArrayEquipamentos.Length; i++)
            {
                if (ArrayEquipamentos[i] != null)
                {
                    if (Ids[i] == id)
                    {
                        //logic
                        ArrayEquipamentos.SetValue(eEditado, i);
                    }
                }
            }

        }

        public void ExcluirEquipamentos(int id)
        {
            for (int i = 0; i < ArrayEquipamentos.Length; i++)
            {
                if (ArrayEquipamentos[i] != null)
                {
                    if (Ids[i] == id)
                    {
                        //logic
                        ArrayEquipamentos = ArrayEquipamentos.Where(val => val != ArrayEquipamentos[i]).ToArray();
                        Ids = Ids.Where(val => val != Ids[i]).ToArray();
                    }
                }
            }

        }
        

    }
}
