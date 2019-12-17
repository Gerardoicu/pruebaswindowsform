using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebasWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }
        private static void PopulateAsesoresTree(TreeView tree)
        {
            List<Asesor> asesores = new List<Asesor> {
                new Asesor { Formiikd="Asesor391" ,Id="391"},
                new Asesor { Formiikd="Asesor311" ,Id="311"},
                new Asesor { Formiikd="Asesor321" ,Id="321"},
                new Asesor { Formiikd="Asesor331" ,Id="331"},
                new Asesor { Formiikd="Asesor351" ,Id="351"},
                new Asesor { Formiikd="Asesor351" ,Id="361"},
                new Asesor { Formiikd="Asesor301" ,Id="301"},
                new Asesor { Formiikd="Asesor381" ,Id="381"},
                new Asesor { Formiikd="Asesor390" ,Id="390"},
                new Asesor { Formiikd="Asesor191" ,Id="191"}
            };
            List <AsesorArbol> arboles = new List<AsesorArbol>();
            foreach(string sucursal in new string[]{"Sucursal1","Sucursal2","Sucursal3" })
            {
                TreeNode node = new TreeNode(sucursal);
                node.Name = string.Format("{0}", sucursal);

             

                foreach (Asesor a in asesores)
                {
                    TreeNode children = new TreeNode(string.Format("{0}", a.Formiikd));
                    children.Name = string.Format("{0}","XXXXXXXXXXXX");
                    node.Nodes.Add(children);

                }
                tree.Nodes.Add(node);
            }

        }
            private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }


        private void Button1_Click(object sender, EventArgs e)
        {
        
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

                for (int i=0;  i< progressBar1.Maximum; ++i)
                {
                progressBar1.Value = i;
                Console.WriteLine(progressBar1);
                }
        }
    }
    class AsesorArbol
    {
        TreeNode nodo;
        Asesor asesor;
    }
    class Asesor
    {
        public string Formiikd { get; set; }
        public string Id { get; set; }

    }
}
