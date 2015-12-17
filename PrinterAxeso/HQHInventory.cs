using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace PrinterAxeso
{
    class HQHInventory
    {
        public class Assets
        {
            public List<Asset> products { get;set; }
            public bool success { get; set; }
        }

        public class Response 
        {
            public bool success { get; set; }
        }

        public List<Asset> getAssets(int idClient)
        {
            Assets assets = new Assets();
            assets.products = new List<Asset>();
            try {
                var request = (HttpWebRequest)WebRequest.Create(Setting.urlApi + "table_products");

                var postData = "username=root";
                postData += "&password=roothqh";
                postData += "&client_id=" + idClient.ToString();
                var data = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                assets = JsonConvert.DeserializeObject<Assets>(responseString);

                
            }
            catch (Exception e) {
                Methods.messageError(e.Message);
            }

            return assets.products;
        }

        public bool setAssetsSequence(int idClient,List<Asset> assets)
        {

            try {
                var request = (HttpWebRequest)WebRequest.Create(Setting.urlApi + "set_table_products_sequence");

                Asset[] assetsArray = new Asset[assets.Count];
                int i = 0;
                foreach (Asset asset in assets)
                {
                    assetsArray[i++] = asset;
                }

                var postData = "username=root";
                postData += "&password=roothqh";
                postData += "&client_id=" + idClient.ToString();
                postData += "&products=" + assetsArray;

                var data = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (Exception exc) {
                return false;
            }
            return true;
        }

    }
}
