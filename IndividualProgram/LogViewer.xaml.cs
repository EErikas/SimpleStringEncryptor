using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.IO;
using SimpleStringEncryptor.Classes;

namespace SimpleStringEncryptor
{
    /// <summary>
    /// Interaction logic for LogViewer.xaml
    /// </summary>
    public partial class LogViewer : Window
    {
        List<string> allLogs = File.ReadAllLines("ActionLog.txt").ToList();
        void ViewAllLogs()
        {
            listBox.Items.Clear();
            foreach (string log in allLogs)
            {
                listBox.Items.Add(log);
            }
        }
        void ViewLogsByAction(string actionName)
        {
            listBox.Items.Clear();
            foreach (string log in allLogs)
            {
                string[] sections = log.Split('-');
                if (sections[2] == actionName)
                {
                    listBox.Items.Add(log);
                }
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------
        public LogViewer()
        {
            InitializeComponent();
            ViewAllLogs();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            if (radioButtonByType.IsChecked == true)
            {
                try
                {
                    ViewLogsByAction(comboBox.SelectedValue.ToString());
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("You must pick a log entry type");
                }
                
            }
            else
            {
                ViewAllLogs();
            }
            
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
