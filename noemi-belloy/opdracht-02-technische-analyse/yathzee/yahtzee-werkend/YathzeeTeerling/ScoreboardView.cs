using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YathzeeTeerling
{
    public partial class ScoreboardView : UserControl
    {
       // private ScoreboardController controller;
        public ScoreboardView( //ScoreboardController c)
            )
        {
            //controller = c;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ScoreboardView_Load(object sender, EventArgs e)
        {
            
        }

        public void updateView()
        {
            //aantalWorpenLabel.Text = controller.HuidigAantalWorpen.ToString();
        }
    }
}
