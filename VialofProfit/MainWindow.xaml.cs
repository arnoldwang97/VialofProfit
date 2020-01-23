using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VialofProfit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Data marketData;

        public MainWindow()
        {
            InitializeComponent();
            marketData = new Data();
            marketData.Initialize();
            FillDataGrid();

        }


        

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ColumnHeader_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FillDataGrid()
        {
            Dictionary<string, Vial> a = marketData.getVials();
            Dictionary<string, Item> b = marketData.getBItems();
            Dictionary<string, Item> c = marketData.getUItems();

            List<ListViewItem> items = new List<ListViewItem>();

            for (int i = 0; i < 11; i++)
            {
                items.Add(new ListViewItem()
                {
                    bIcon = new BitmapImage(new Uri(b[ItemLists.baseNames[i]].icon)),
                    bName = ItemLists.baseNames[i],
                    bPrice = b[ItemLists.baseNames[i]].mean,
                    vIcon = new BitmapImage(new Uri(a[ItemLists.vialNames[i]].icon)),
                    vName = ItemLists.vialNames[i],
                    vPrice = a[ItemLists.vialNames[i]].mean,
                    uIcon = new BitmapImage(new Uri(c[ItemLists.upgradeNames[i]].icon)),
                    uName = ItemLists.upgradeNames[i],
                    uPrice = c[ItemLists.upgradeNames[i]].mean,
                    Profit = c[ItemLists.upgradeNames[i]].mean - a[ItemLists.vialNames[i]].mean - b[ItemLists.baseNames[i]].mean
                });

            }
            listView1.ItemsSource = items;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(listView1.ItemsSource);
            view.SortDescriptions.Add(new SortDescription("Profit", ListSortDirection.Descending));


        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }

}
