using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReadWriteCsv;
using System.IO;
using smw;

namespace PrinterAxeso
{
    class TagPrinter
    {
        private Config rconfig;
        private List<TagPrint> tprint;
        private string ttemplate="";
        private List<Asset> assets;
        public TagPrinter(Config tempconfig, List<Asset> assets)
        {
            this.assets = assets;
            rconfig = tempconfig;

            tprint = new List<TagPrint>();
            getTags();

            ttemplate = File.ReadAllText(rconfig.TemplatePath);
            createPrintFile();
        }

        public void printTags(){
            File.Copy(AssemblyDirectory + "\\calibrate.txt", rconfig.PrinterPath);
            File.Copy(AssemblyDirectory + "\\printfile.txt", rconfig.PrinterPath);
        }

        private void createPrintFile()
        {
            string finaltextfile = "";
            string temptemplate = "";
            string epc = "";

            EpcTools epctool = new EpcTools();

            foreach (TagPrint tag in tprint)
            {
                if (tag.count > 0)
                {
                    for (int i = 0; i < tag.count; i++)
                    {
                        temptemplate = ttemplate;
                        epc = epctool.getNewEPC(48, 1, 5, tag.upc, tag.sequence);
                        temptemplate = temptemplate.Replace("<<EPC>>", epc);
                        temptemplate = temptemplate.Replace("<<UPC>>", tag.upc);
                        temptemplate = temptemplate.Replace("<<NAME>>", tag.name);
                        temptemplate = temptemplate.Replace("<<BARCODEEPC>>", tag.upc);
                        finaltextfile = finaltextfile + temptemplate;
                        temptemplate = "";
                        tag.sequence = tag.sequence++;
                    }
                }
            }
            setSequence();
            File.WriteAllText(AssemblyDirectory + "\\printfile.txt", finaltextfile);
        }

        private void setSequence()
        {

        }

        private void getTags()
        {

            TagPrint temptags;
            foreach(Asset asset in assets)
            {
                temptags = new TagPrint();
                temptags.upc = asset.upc;
                temptags.name = asset.product_name;
                temptags.count = asset.count;
                temptags.sequence = asset.last_serial;
                tprint.Add(temptags);
            }
        }

        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
    }

    public class TagPrint
    {
        public string upc { get; set; }
        public string name { get; set; }
        public int count { get; set; }
        public int sequence { get; set; }
    }

}
