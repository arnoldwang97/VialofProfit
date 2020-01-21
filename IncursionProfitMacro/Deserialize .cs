using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace IncursionProfitMacro
{
    class Vial
    {
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string group { get; set; }
        public int frame { get; set; }
        public string[] influences { get; set; }
        public int stackSize { get; set; }
        public string icon { get; set; }
        public float mean { get; set; }
        public float median { get; set; }
        public float mode { get; set; }
        public float min { get; set; }
        public float max { get; set; }
        public float exalted { get; set; }
        public int total { get; set; }
        public int daily { get; set; }
        public int current { get; set; }
        public int accepted { get; set; }
        public float change { get; set; }
        public List<float> history { get; set; }
    }

    class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string category { get; set; }
        public string group { get; set; }
        public int frame { get; set; }
        public string[] influences { get; set; }
        public int stackSize { get; set; }
        public string icon { get; set; }
        public float mean { get; set; }
        public float median { get; set; }
        public float mode { get; set; }
        public float min { get; set; }
        public float max { get; set; }
        public float exalted { get; set; }
        public int total { get; set; }
        public int daily { get; set; }
        public int current { get; set; }
        public int accepted { get; set; }
        public float change { get; set; }
        public List<float> history { get; set; }
    }

    class ListViewItem
    {
        public BitmapImage bIcon { get; set; }
        public string bName { get; set; }
        public float bPrice { get; set; }
        public BitmapImage vIcon { get; set; }
        public string vName { get; set; }
        public float vPrice { get; set; }
        public BitmapImage uIcon { get; set; }
        public string uName { get; set; }
        public float uPrice { get; set; }
        public float Profit { get; set; }
    }
}
