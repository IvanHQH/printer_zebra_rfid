using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrinterAxeso
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AceptButton_Click(object sender, EventArgs e)
        {
            saveChanges();
        }

        private void saveChanges()
        {
            String errors = validate();
            if (errors.Length == 0)
            {
                string lines = "";

                lines = "id_client " + IdClientTextBox.Text + '\n';
                lines += "url_api " + urlApiTextBox.Text + '\n';
                lines += "client " +  clientTextBox.Text + '\n';
                lines += "password " + Setting.password + '\n';

                File.WriteAllText(Setting.pathDirectory, lines);
            }
            else
            {
                messageLabel.Visible = true;
                messageLabel.Text = errors;
            }
        }
        private string validate()
        {
            String errors = "";
            if (urlApiTextBox.TextLength == 0)
                errors += " Indique una url,";
            if (IdClientTextBox.TextLength == 0)
                errors += " Indique un id del cliente,";
            if (clientTextBox.TextLength == 0)
                errors += " Indique un cleinte";
            if(errors.Length > 0)
                errors = errors.Remove(errors.Length - 1);
            return errors;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            messageLabel.Visible = false;
            clientTextBox.Text = Setting.client;
            urlApiTextBox.Text = Setting.urlApi;
            IdClientTextBox.Text = Setting.idClient.ToString();
        }

    }
}
