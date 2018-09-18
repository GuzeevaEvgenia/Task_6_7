using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Draw;
using Tools;

namespace _5
{
    public partial class TreeForm : Form
    {
        public TreeForm()
        {
            InitializeComponent();
        }
        Tree tree;
        TreeDraw draw;
        private void TreeForm_Load(object sender, EventArgs e)
        {
            tree = new Tree();
            tree.Generate(1);
            draw = new TreeDraw(output.Size, tree);
            output.Image = draw.Draw();
        }

        private void TreeForm_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Gen_Click(object sender, EventArgs e)
        {
            tree.Generate((int)InputN.Value + 1);
            output.Image = draw.Draw();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, tree.GetWays(positiveBtn.Checked));
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tree.GetWays(positiveBtn.Checked));
        }
    }
}
