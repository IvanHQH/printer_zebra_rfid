using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrinterAxeso
{
    class Setting
    {
        public static string pathDirectory = @".\setting.txt";
        public static string urlApi;
        public static string client;
        public static int idClient;
        public static string password;

        public static bool load(){

            string line;

            try {
                System.IO.StreamReader file = new System.IO.StreamReader(pathDirectory);
                while ((line = file.ReadLine()) != null)
                {
                    string[] split = line.Split(new Char[] { ' ' });
                    if (split.Length > 1)
                    {
                        switch (split[0])
                        {
                            case "url_api":
                                urlApi = split[1];
                                break;
                            case "id_client":
                                try { idClient = int.Parse(split[1]); }
                                catch (Exception e) { return false; }
                                break;
                            case "client":
                                for (int i = 1; i < split.Length; i++)
                                    client += split[i] + " ";
                                if (client.Length > 0)
                                    client = client.Remove(client.Length - 1);
                                break;
                            case "password":
                                password = split[1];
                                break;
                        }
                    }
                    else if (split.Length == 1) {
                        if (split[0].Length > 0)
                            return false;
                    }
                }

                file.Close();            
            }
            catch (Exception e)
            {
                Methods.messageError(e.Message);
                return false;
            }
            return true;
            
        }

    }
}
