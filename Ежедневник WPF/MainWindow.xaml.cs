using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ежедневник_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string date_global;
        List<Jsonnes> jsonnes = new List<Jsonnes>();
        Jsonnes Jsonnes = new Jsonnes();
        public MainWindow()
        {
            InitializeComponent();
        } 
        
        private void Celebreat_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime date = Convert.ToDateTime(Celebreat.Text);
            date_global = date.ToShortDateString();
        }
        private void Creat_Click(object sender, RoutedEventArgs e)
        {
            Jsonnes.name=Name.Text;
            Jsonnes.opisanie = OSI.Text;
            Jsonnes.date=date_global;
            jsonnes.Add(Jsonnes);
            Listyy.ItemsSource = jsonnes;
            Listyy.DisplayMemberPath = "name";
            Name.Text = null;
            OSI.Text = null;
            Jsonnes.Serialize(jsonnes);
            //List<Jsonnes> result=JsonConvert.DeserializeObject<List<Jsonnes>>(text);
        }
        private void Delet_Click(object sender, RoutedEventArgs e)
        {
            Listyy.ItemsSource = null;
            Listyy.DisplayMemberPath=null;
            jsonnes.Clear();
            string json = JsonConvert.SerializeObject(jsonnes);
            File.WriteAllText("C:\\Users\\nikol\\Desktop\\Day.json", json);
        }
    }
}
