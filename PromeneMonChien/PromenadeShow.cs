using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class PromenadeShow : Form
    {
        public PromenadeShow()
        {
            InitializeComponent();
        }

        private void PromenadeShow_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.promenade'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.promenadeTableAdapter.Fill(this.promenemonchienDataSet.promenade);

        }
    }
}
