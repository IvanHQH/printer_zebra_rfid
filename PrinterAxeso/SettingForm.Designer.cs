namespace PrinterAxeso
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AceptButton = new System.Windows.Forms.Button();
            this.urlApiTextBox = new System.Windows.Forms.TextBox();
            this.urlApiLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.IdClientLabel = new System.Windows.Forms.Label();
            this.IdClientTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AceptButton
            // 
            this.AceptButton.Location = new System.Drawing.Point(190, 192);
            this.AceptButton.Name = "AceptButton";
            this.AceptButton.Size = new System.Drawing.Size(75, 23);
            this.AceptButton.TabIndex = 0;
            this.AceptButton.Text = "Aceptar";
            this.AceptButton.UseVisualStyleBackColor = true;
            this.AceptButton.Click += new System.EventHandler(this.AceptButton_Click);
            // 
            // urlApiTextBox
            // 
            this.urlApiTextBox.Location = new System.Drawing.Point(12, 24);
            this.urlApiTextBox.Name = "urlApiTextBox";
            this.urlApiTextBox.Size = new System.Drawing.Size(253, 20);
            this.urlApiTextBox.TabIndex = 1;
            // 
            // urlApiLabel
            // 
            this.urlApiLabel.AutoSize = true;
            this.urlApiLabel.Location = new System.Drawing.Point(9, 8);
            this.urlApiLabel.Name = "urlApiLabel";
            this.urlApiLabel.Size = new System.Drawing.Size(49, 13);
            this.urlApiLabel.TabIndex = 2;
            this.urlApiLabel.Text = "URL API";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(9, 108);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(39, 13);
            this.clientLabel.TabIndex = 4;
            this.clientLabel.Text = "Cliente";
            // 
            // clientTextBox
            // 
            this.clientTextBox.Location = new System.Drawing.Point(12, 124);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.Size = new System.Drawing.Size(253, 20);
            this.clientTextBox.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 192);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.BackColor = System.Drawing.Color.Coral;
            this.messageLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.messageLabel.Location = new System.Drawing.Point(12, 154);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(253, 29);
            this.messageLabel.TabIndex = 6;
            this.messageLabel.Text = "Mensaje de error";
            this.messageLabel.Visible = false;
            // 
            // IdClientLabel
            // 
            this.IdClientLabel.AutoSize = true;
            this.IdClientLabel.Location = new System.Drawing.Point(9, 55);
            this.IdClientLabel.Name = "IdClientLabel";
            this.IdClientLabel.Size = new System.Drawing.Size(51, 13);
            this.IdClientLabel.TabIndex = 8;
            this.IdClientLabel.Text = "Id Cliente";
            // 
            // IdClientTextBox
            // 
            this.IdClientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdClientTextBox.Location = new System.Drawing.Point(12, 71);
            this.IdClientTextBox.Name = "IdClientTextBox";
            this.IdClientTextBox.Size = new System.Drawing.Size(75, 29);
            this.IdClientTextBox.TabIndex = 7;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 226);
            this.Controls.Add(this.IdClientLabel);
            this.Controls.Add(this.IdClientTextBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.clientTextBox);
            this.Controls.Add(this.urlApiLabel);
            this.Controls.Add(this.urlApiTextBox);
            this.Controls.Add(this.AceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración RFID HQH";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AceptButton;
        private System.Windows.Forms.TextBox urlApiTextBox;
        private System.Windows.Forms.Label urlApiLabel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label IdClientLabel;
        private System.Windows.Forms.TextBox IdClientTextBox;
    }
}