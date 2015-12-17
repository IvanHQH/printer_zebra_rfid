using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrinterAxeso
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AceptButton_Click(object sender, EventArgs e)
        {
            if (Setting.password == passwordTextBox.Text)
                DialogResult = DialogResult.OK;
            else
                Methods.messageError("Autenticación invalida");
        }
    }
}
