using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplexGUI.Forms
{
    public partial class frmAnswer : MetroForm
    {
        public frmAnswer(string answer) : base()
        {
            InitializeComponent();

            TbxAnswer.Text = answer;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
