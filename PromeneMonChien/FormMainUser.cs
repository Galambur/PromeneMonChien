using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class FormMainUser : Form
    {
        int userId;

        public FormMainUser()
        {
            InitializeComponent();
        }

        public FormMainUser(int id)
        {
            InitializeComponent();
            userId = id;
        }

    }
}
