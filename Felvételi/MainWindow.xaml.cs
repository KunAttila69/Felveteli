using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace Felvételi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Diak> diakok = new();
        public MainWindow()
        {
            InitializeComponent(); 
        }

        private void LoadData(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
             

            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(";");
                diakok.Add(new Diak(line[0], line[1], line[2], DateTime.Parse(line[3]), line[4], Convert.ToInt16(line[5]),Convert.ToInt16(line[6]), line[7], line[8]));
            }
            sr.Close();
            dg_diakok.ItemsSource = diakok;
        }

        private void SaveData(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);

            foreach (var diak in diakok)
            {
                sw.WriteLine($"{diak.Az};{diak.Nev};{diak.ErtCím};{diak.SzülDatum};{diak.Email};{diak.MatekPontok};{diak.MagyarPontok};{diak.Telefon};{diak.Iskola}");
            }
            sw.Close();
        }

        private void btn_import_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            string fileName = openFileDialog.FileName;
            if (fileName != "")
            {
                LoadData(fileName);
            }
        }

        private void btn_export_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();

            string fileName = saveFileDialog.FileName;
            if(fileName != "")
            {
                SaveData(fileName);
            }
        }

        private void btn_torol_Click(object sender, RoutedEventArgs e)
        {
            if (dg_diakok.SelectedIndex != -1)
            {
                diakok.Remove(diakok[dg_diakok.SelectedIndex]);
                dg_diakok.Items.Refresh();
                dg_diakok.ItemsSource = diakok;
            }
        }

        private void btn_hozzaad_Click(object sender, RoutedEventArgs e)
        {
            AddUser addUser = new AddUser();

            addUser.ShowDialog();
        }
    }
}
