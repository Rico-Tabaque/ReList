using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void accordionControlHome_Click(object sender, EventArgs e)
        {
            navigationFrame.SelectedPage = navigationPage1;
        }

        private void accordionControlSettings_Click(object sender, EventArgs e)
        {
            navigationFrame.SelectedPage = navigationPage2;
        }
    }
}