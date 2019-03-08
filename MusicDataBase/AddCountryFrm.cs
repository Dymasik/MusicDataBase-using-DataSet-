using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicDataBase
{
    public partial class AddCountryFrm : Form
    {
        private string name = "";

        public AddCountryFrm()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            name = tBName.Text;
            if (!name.Equals(""))
            {
                this.Close();
            }
        }

        public string GetName() { return name; }
    }
}
