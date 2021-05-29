using System;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class DogsShow : Form
    {
        public DogsShow()
        {
            InitializeComponent();
        }

        private void ShowDogs_Load(object sender, EventArgs e)
        {
            this.chienTableAdapter.Fill(this.promenemonchienDataSet.chien);
            this.chienTableAdapter.Fill(this.promenemonchienDataSet.chien);
        }
    }
}
