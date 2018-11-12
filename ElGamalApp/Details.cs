using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElGamalApp
{
    public partial class Details : Form
    {
        private string _Details;
        public Details(string details)
        {
            _Details = details;
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            txtDetails.Text = _Details;
        }
    }
}
