using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using smw;
using System.Drawing.Printing;

namespace PrinterAxeso
{
    public partial class Main : Form
    {
        private Config rconfig;
        private List<Asset> assets;

        public enum colsAssetGrid
        {
            name = 0,
            upc = 1,
            serial = 2,
            count = 3
        }

        public Main()
        {
            InitializeComponent();
            rconfig = JsonConvert.DeserializeObject<Config>(File.ReadAllText(@".\config.json"));
            templatePath.Text = rconfig.TemplatePath;

            if (Setting.load() == false)
            {
                Methods.messageError("Error en archivo de configuracion setting.txt");
                Application.Exit();
            }
            HQHInventory hqh = new HQHInventory();
            assets = hqh.getAssets(Setting.idClient);

            String pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                PrinterInstalledComboBox.Items.Add("\\\\" + System.Environment.MachineName + "\\" + pkInstalledPrinters);

            }

            PrinterInstalledComboBox.SelectedText = rconfig.PrinterPath;

        }

        private void templateButton_Click(object sender, EventArgs e)
        {
            templateFileDialog.ShowDialog();
        }

        private void templateFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            rconfig.TemplatePath = templateFileDialog.FileName;
            templatePath.Text = templateFileDialog.FileName;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (PrinterInstalledComboBox.SelectedIndex == -1)
                Methods.messageError("Seleccione una impresora");
            else
            {
                List<Asset> assetsPrint = AssetsPrint();
                TagPrinter printer = new TagPrinter(rconfig, assetsPrint);
                printer.printTags();            
            }
        }

        private List<Asset> AssetsPrint()
        {
            List<Asset> assetsPrint = new List<Asset>();
            Asset asset;

            foreach (DataGridViewRow rowGrid in AssetsDataGridView.Rows) 
            {
                asset = new Asset();
                asset.product_name = rowGrid.Cells[(int)colsAssetGrid.name].Value.ToString();
                asset.last_serial = int.Parse(rowGrid.Cells[(int)colsAssetGrid.serial].Value.ToString());
                asset.upc = rowGrid.Cells[(int)colsAssetGrid.upc].Value.ToString();
                asset.count = int.Parse(rowGrid.Cells[(int)colsAssetGrid.count].Value.ToString());
                assetsPrint.Add(asset);            
            }

            return assetsPrint;
        }

        private void PrinterBox_TextChanged(object sender, EventArgs e)
        {
            rconfig.PrinterPath = PrinterInstalledComboBox.Text;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText(@".\config.json", JsonConvert.SerializeObject(rconfig));
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<Asset> assetsFound = foundAssetWith(searchTextBox.Text);
            if (getCountStr() == "0") { 
                Methods.messageError("Indique una cantidad");
            }
            else{
                if (assetsFound.Count > 0)
                {
                    if (assetsFound.Count > 1)
                    {
                        showAssetsFound(assetsFound);
                    }
                    else
                    {
                        addAssetToGrid(assetsFound[0]);
                        clearSearch();
                    }
                }
            }
            countTextBox.Focus();
        }

        private void addAssetToGrid(Asset asset)
        {
            string countStr = getCountStr();
            AssetsDataGridView.Rows.Add(asset.product_name, asset.upc,asset.last_serial,countStr,"X");
            updateCountRows();
        }

        public void updateCountRows()
        {
            int total = 0;
            int count;
            foreach(DataGridViewRow row in AssetsDataGridView.Rows)
            {                
                 if (Int32.TryParse(row.Cells[(int)colsAssetGrid.count].Value.ToString(), out count) == true)
                 {
                     total = total + count;
                 }
            }
            totalTagsLabel.Text = "Total : " + total.ToString();
        }

        private string getCountStr()
        {
            string countStr = "0";
            int countInt;

            if (Int32.TryParse(countTextBox.Text, out countInt))
                countStr = countTextBox.Text;

            return countStr;
        }

        private void showAssetsFound(List<Asset> assetsFound)
        {
            closeSearchSelectButton.Visible = true;
            selectDataGridView.Visible = true;
            selectDataGridView.Rows.Clear();
            foreach(Asset asset in assetsFound)
                selectDataGridView.Rows.Add(asset.product_name,asset.upc,asset.last_serial);
            selectDataGridView.BringToFront();
            if (assetsFound.Count < 10)
                selectDataGridView.Height = selectDataGridView.RowTemplate.Height * assetsFound.Count;
            else
                selectDataGridView.Height = selectDataGridView.RowTemplate.Height * 10;
        }

        private List<Asset> foundAssetWith(string text)
        {

            List<Asset> foundAssets = new List<Asset>();
            bool band;
            if (assets != null)
            {
                foreach (Asset asset in assets)
                {
                    band = false;
                    if (asset.upc.Contains(text))
                    {
                        band = true;
                        foundAssets.Add(asset);
                    }
                    if (band == false)
                    {
                        if (asset.product_name.Contains(text))
                            foundAssets.Add(asset);
                    }
                }
            }
            else {
                Methods.messageError("No hay activos almacenados en esta aplicación");
            }
            return foundAssets;

        }

        private void AssetsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AssetsDataGridView.CurrentCell.ColumnIndex == AssetsDataGridView.Columns.Count - 1) 
            {
                AssetsDataGridView.Rows.RemoveAt(AssetsDataGridView.CurrentCell.RowIndex);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            AssetsDataGridView.Rows.Clear();
        }

        private void selectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addAssetToGrid(string name, string upc, string lastSerial)
        {
            string countStr = getCountStr();
            AssetsDataGridView.Rows.Add(name, upc,lastSerial.ToString(),countStr,"x");
            countTextBox.Focus();
            updateCountRows();
        }

        private void selectDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rowGrid = selectDataGridView.CurrentRow;
            if (rowGrid != null)
            {
                addAssetToGrid(rowGrid.Cells[0].Value.ToString(), rowGrid.Cells[1].Value.ToString(),rowGrid.Cells[2].Value.ToString());
                selectDataGridView.Visible = false;
                closeSearchSelectButton.Visible = false;
                clearSearch();
            }
        }

        private void clearSearch()
        {
            searchTextBox.Text = "";
            countTextBox.Text = "";
        }

        private void configButton_Click(object sender, EventArgs e)
        {
            Authentication authForm = new Authentication();
            if( authForm.ShowDialog() == DialogResult.OK)
            {
                SettingForm settingForm = new SettingForm();
                settingForm.Show();
            }
        }

        private void countTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void AssetsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void AssetsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == (int)colsAssetGrid.count) // 1 should be your column index
            {
                int i;
                string value = AssetsDataGridView.Rows[e.RowIndex].Cells[(int)colsAssetGrid.count].Value.ToString();
                if (!int.TryParse(Convert.ToString(value), out i))
                {
                    //e.Cancel = true;
                    DataGridViewRow row = AssetsDataGridView.Rows[e.RowIndex];
                    row.Cells[e.ColumnIndex].Value = "0";
                    Methods.messageError(Convert.ToString(value) + " No es un número");
                }
                else
                {
                    updateCountRows();
                }
            }
        }

        private void closeSearchSelectButton_Click(object sender, EventArgs e)
        {
            closeSearchSelectButton.Visible = false;
            selectDataGridView.Visible = false;
        }

    }

    public class Config
    {
        public string PrinterPath { get; set; }
        public string TemplatePath { get; set; }
    }
}
