using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Shapes;
using System.IO;
using HtmlAgilityPack;
using System.Net.Http;
using System.Collections;
using System.Web.UI.WebControls;

namespace IncursionProfitMacro
{
    class Data
    {
        private Dictionary<string, Vial> vials;
        private Dictionary<string, Item> bItems;
        private Dictionary<string, Item> uItems;

        public Data()
        {
            vials = new Dictionary<string, Vial>();
            bItems = new Dictionary<string, Item>();
            uItems = new Dictionary<string, Item>();
        }

        public void Initialize()
        {
            fetchData("currency");
            foreach (string category in ItemLists.baseDict.Keys)
            {
                fetchData(category);
            }
        }


        public void fetchData(string category, string league = "Metamorph")
        {
            string data;
            ArrayList JSONItems;
            string JSONRequest = "https://api.poe.watch/get?league=" + league + "&category=" + category;


            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(JSONRequest);
            WebResponse response = request.GetResponse();

            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                data = reader.ReadToEnd();

            }

            JSONItems = JsonConvert.DeserializeObject<ArrayList>(data);

            for (int i = 0; i < JSONItems.Count; i++)
            {
                dynamic elem = new System.Dynamic.ExpandoObject();
                elem = JSONItems[i];
                
                if (category == "currency")
                {
                    //MessageBox.Show(elem.name.ToString());
                    //MessageBox.Show(elem.name.GetType().ToString());
                    if (Array.IndexOf(ItemLists.vialNames, elem.name.ToString()) > -1)
                    {
                        var json = JsonConvert.SerializeObject(elem);
                        Vial vial = JsonConvert.DeserializeObject<Vial>(json);
                        vials.Add(vial.name, vial);
                    }
                    
                }
                
                else
                {
                    if (ItemLists.baseDict[category].Contains(elem.name.ToString()))
                    {
                        var json = JsonConvert.SerializeObject(elem);
                        Item item = JsonConvert.DeserializeObject<Item>(json);
                        bItems.Add(item.name, item);
                    }
                    else if (ItemLists.upgradeDict[category].Contains(elem.name.ToString()))
                    {
                        var json = JsonConvert.SerializeObject(elem);
                        Item item = JsonConvert.DeserializeObject<Item>(json);
                        uItems.Add(item.name, item);
                    }
                    
                }
                
            }

        }

        public Dictionary<string, Vial> getVials()
        {
            return vials;
        }
        public Dictionary<string, Item> getBItems()
        {
            return bItems;
        }
        public Dictionary<string, Item> getUItems()
        {
            return uItems;
        }
    }
}
