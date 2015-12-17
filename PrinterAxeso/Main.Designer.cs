namespace PrinterAxeso
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.templatePath = new System.Windows.Forms.Label();
            this.PrinterPath = new System.Windows.Forms.Label();
            this.templateButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.templateFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.AssetsDataGridView = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.selectDataGridView = new System.Windows.Forms.DataGridView();
            this.colNameFound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpcFound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastSerialFound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.configButton = new System.Windows.Forms.Button();
            this.PrinterInstalledComboBox = new System.Windows.Forms.ComboBox();
            this.totalTagsLabel = new System.Windows.Forms.Label();
            this.closeSearchSelectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AssetsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDataGridView)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // templatePath
            // 
            this.templatePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templatePath.Location = new System.Drawing.Point(101, 22);
            this.templatePath.Name = "templatePath";
            this.templatePath.Size = new System.Drawing.Size(532, 23);
            this.templatePath.TabIndex = 2;
            this.templatePath.Text = "--";
            // 
            // PrinterPath
            // 
            this.PrinterPath.AutoSize = true;
            this.PrinterPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrinterPath.Location = new System.Drawing.Point(6, 55);
            this.PrinterPath.Name = "PrinterPath";
            this.PrinterPath.Size = new System.Drawing.Size(66, 15);
            this.PrinterPath.TabIndex = 3;
            this.PrinterPath.Text = "Impresora:";
            // 
            // templateButton
            // 
            this.templateButton.Location = new System.Drawing.Point(639, 22);
            this.templateButton.Name = "templateButton";
            this.templateButton.Size = new System.Drawing.Size(75, 23);
            this.templateButton.TabIndex = 5;
            this.templateButton.Text = "Seleccionar";
            this.templateButton.UseVisualStyleBackColor = true;
            this.templateButton.Click += new System.EventHandler(this.templateButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(658, 546);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 7;
            this.PrintButton.Text = "Imprimir";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Template:";
            // 
            // templateFileDialog
            // 
            this.templateFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.templateFileDialog_FileOk);
            // 
            // AssetsDataGridView
            // 
            this.AssetsDataGridView.AllowUserToAddRows = false;
            this.AssetsDataGridView.AllowUserToResizeRows = false;
            this.AssetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssetsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colUpc,
            this.colLastSerial,
            this.colCount,
            this.colDelete});
            this.AssetsDataGridView.Location = new System.Drawing.Point(9, 98);
            this.AssetsDataGridView.Name = "AssetsDataGridView";
            this.AssetsDataGridView.RowHeadersVisible = false;
            this.AssetsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssetsDataGridView.Size = new System.Drawing.Size(696, 237);
            this.AssetsDataGridView.TabIndex = 13;
            this.AssetsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssetsDataGridView_CellClick);
            this.AssetsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssetsDataGridView_CellEndEdit);
            this.AssetsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.AssetsDataGridView_CellValidating);
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Nombre";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colUpc
            // 
            this.colUpc.HeaderText = "UPC";
            this.colUpc.Name = "colUpc";
            this.colUpc.ReadOnly = true;
            this.colUpc.Width = 200;
            // 
            // colLastSerial
            // 
            this.colLastSerial.HeaderText = "Ultimo Serial";
            this.colLastSerial.Name = "colLastSerial";
            // 
            // colCount
            // 
            this.colCount.HeaderText = "Cantidad";
            this.colCount.Name = "colCount";
            this.colCount.Width = 50;
            // 
            // colDelete
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDelete.HeaderText = "X";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Width = 30;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.White;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(67, 38);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(603, 26);
            this.searchTextBox.TabIndex = 14;
            // 
            // selectDataGridView
            // 
            this.selectDataGridView.AllowUserToAddRows = false;
            this.selectDataGridView.AllowUserToResizeRows = false;
            this.selectDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectDataGridView.ColumnHeadersVisible = false;
            this.selectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNameFound,
            this.colUpcFound,
            this.colLastSerialFound});
            this.selectDataGridView.Location = new System.Drawing.Point(67, 63);
            this.selectDataGridView.Name = "selectDataGridView";
            this.selectDataGridView.RowHeadersVisible = false;
            this.selectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectDataGridView.Size = new System.Drawing.Size(603, 32);
            this.selectDataGridView.TabIndex = 16;
            this.selectDataGridView.Visible = false;
            this.selectDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectDataGridView_CellContentClick);
            this.selectDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectDataGridView_CellDoubleClick);
            // 
            // colNameFound
            // 
            this.colNameFound.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNameFound.HeaderText = "Nombre";
            this.colNameFound.Name = "colNameFound";
            // 
            // colUpcFound
            // 
            this.colUpcFound.HeaderText = "EPC";
            this.colUpcFound.Name = "colUpcFound";
            this.colUpcFound.Width = 200;
            // 
            // colLastSerialFound
            // 
            this.colLastSerialFound.HeaderText = "Ultimo Serial";
            this.colLastSerialFound.Name = "colLastSerialFound";
            this.colLastSerialFound.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(620, 72);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(85, 23);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Eliminar Todo";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // countTextBox
            // 
            this.countTextBox.BackColor = System.Drawing.Color.White;
            this.countTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countTextBox.Location = new System.Drawing.Point(10, 38);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(51, 26);
            this.countTextBox.TabIndex = 18;
            this.countTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countTextBox_KeyPress);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.PrinterInstalledComboBox);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.templatePath);
            this.GroupBox1.Controls.Add(this.PrinterPath);
            this.GroupBox1.Controls.Add(this.templateButton);
            this.GroupBox1.Location = new System.Drawing.Point(11, 60);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(722, 87);
            this.GroupBox1.TabIndex = 21;
            this.GroupBox1.TabStop = false;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.closeSearchSelectButton);
            this.GroupBox2.Controls.Add(this.totalTagsLabel);
            this.GroupBox2.Controls.Add(this.searchLabel);
            this.GroupBox2.Controls.Add(this.countLabel);
            this.GroupBox2.Controls.Add(this.AssetsDataGridView);
            this.GroupBox2.Controls.Add(this.searchTextBox);
            this.GroupBox2.Controls.Add(this.searchButton);
            this.GroupBox2.Controls.Add(this.selectDataGridView);
            this.GroupBox2.Controls.Add(this.deleteButton);
            this.GroupBox2.Controls.Add(this.countTextBox);
            this.GroupBox2.Location = new System.Drawing.Point(11, 166);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(722, 374);
            this.GroupBox2.TabIndex = 22;
            this.GroupBox2.TabStop = false;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(68, 16);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(90, 15);
            this.searchLabel.TabIndex = 23;
            this.searchLabel.Text = "Nombre o UPC";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.Location = new System.Drawing.Point(6, 16);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(56, 15);
            this.countLabel.TabIndex = 10;
            this.countLabel.Text = "Cantidad";
            // 
            // searchButton
            // 
            this.searchButton.Image = global::PrinterAxeso.Properties.Resources.search;
            this.searchButton.Location = new System.Drawing.Point(676, 37);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(29, 30);
            this.searchButton.TabIndex = 15;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PrinterAxeso.Properties.Resources.ge1;
            this.pictureBox2.Location = new System.Drawing.Point(1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrinterAxeso.Properties.Resources.hqh31;
            this.pictureBox1.Location = new System.Drawing.Point(650, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // configButton
            // 
            this.configButton.Image = global::PrinterAxeso.Properties.Resources.setting;
            this.configButton.Location = new System.Drawing.Point(596, 10);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(39, 37);
            this.configButton.TabIndex = 12;
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // PrinterInstalledComboBox
            // 
            this.PrinterInstalledComboBox.BackColor = System.Drawing.Color.White;
            this.PrinterInstalledComboBox.FormattingEnabled = true;
            this.PrinterInstalledComboBox.Location = new System.Drawing.Point(104, 54);
            this.PrinterInstalledComboBox.Name = "PrinterInstalledComboBox";
            this.PrinterInstalledComboBox.Size = new System.Drawing.Size(520, 21);
            this.PrinterInstalledComboBox.TabIndex = 23;
            // 
            // totalTagsLabel
            // 
            this.totalTagsLabel.AutoSize = true;
            this.totalTagsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTagsLabel.Location = new System.Drawing.Point(655, 347);
            this.totalTagsLabel.Name = "totalTagsLabel";
            this.totalTagsLabel.Size = new System.Drawing.Size(50, 15);
            this.totalTagsLabel.TabIndex = 24;
            this.totalTagsLabel.Text = "Total : 0";
            // 
            // closeSearchSelectButton
            // 
            this.closeSearchSelectButton.BackColor = System.Drawing.Color.Red;
            this.closeSearchSelectButton.Location = new System.Drawing.Point(48, 64);
            this.closeSearchSelectButton.Name = "closeSearchSelectButton";
            this.closeSearchSelectButton.Size = new System.Drawing.Size(19, 23);
            this.closeSearchSelectButton.TabIndex = 24;
            this.closeSearchSelectButton.Text = "x";
            this.closeSearchSelectButton.UseVisualStyleBackColor = false;
            this.closeSearchSelectButton.Visible = false;
            this.closeSearchSelectButton.Click += new System.EventHandler(this.closeSearchSelectButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(745, 581);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.PrintButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresión RFID HQH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AssetsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDataGridView)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label templatePath;
        private System.Windows.Forms.Label PrinterPath;
        private System.Windows.Forms.Button templateButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog templateFileDialog;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.DataGridView AssetsDataGridView;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView selectDataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpcFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastSerialFound;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.ComboBox PrinterInstalledComboBox;
        private System.Windows.Forms.Label totalTagsLabel;
        private System.Windows.Forms.Button closeSearchSelectButton;
    }
}

