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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SimpleStringEncryptor.Classes;


namespace SimpleStringEncryptor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Log actionLog = new Log();

        public MainWindow()
        {
            InitializeComponent();
            
            actionLog.AddLogEntry("Application opened", "");
            textBoxResult.IsReadOnly = true;
            
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            actionLog.AddLogEntry("Application closed", "");
            actionLog.SaveLogFile();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            actionLog.AddLogEntry("Button clicked", "About");
            new AboutBox().Show();
        }

        private void buttonEncrypt_Click(object sender, RoutedEventArgs e)
        {
            actionLog.AddLogEntry("Button clicked", "Encrypt");
            if (!string.IsNullOrWhiteSpace(textBoxString.Text) && !string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                try
                {
                    textBoxResult.Text = Encrypt.EncryptionAction(textBoxString.Text, textBoxPassword.Text, true);
                    textBoxString.Text = "";

                    actionLog.AddLogEntry("Action Completed", "Encrypt");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to complete task");
                    actionLog.AddLogEntry("Error", "Encryption error    ");
                }
            }
        }

        private void buttonDecrypt_Click(object sender, RoutedEventArgs e)
        {
            actionLog.AddLogEntry("Button clicked", "Decrypt");
            if (!string.IsNullOrWhiteSpace(textBoxString.Text) && !string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                try
                {
                    textBoxResult.Text = Encrypt.EncryptionAction(textBoxString.Text, textBoxPassword.Text, false);
                    textBoxString.Text = "";

                    actionLog.AddLogEntry("Action Completed", "Decrypt");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to complete task");
                    actionLog.AddLogEntry("Error", "Dcryption Error: wrong password");
                }
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            actionLog.AddLogEntry("Button clicked", "View Logs");
            actionLog.SaveLogFile();
            new LogViewer().Show();
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            actionLog.AddLogEntry("Button clicked", "Clear");

            textBoxString.Text = "";
            textBoxPassword.Text = "";
            textBoxResult.Text = "";

            actionLog.AddLogEntry("Action Completed", "Clear");
        }

        private void buttonSwap_Click(object sender, RoutedEventArgs e)
        {
            actionLog.AddLogEntry("Button clicked", "Swap");

            textBoxString.Text = textBoxResult.Text;
            textBoxResult.Text = "";

            actionLog.AddLogEntry("Action Completed", "Swap");
        }

        private void buttonCopy_Click(object sender, RoutedEventArgs e)
        {
            actionLog.AddLogEntry("Button clicked", "Copy");

            Clipboard.SetText(textBoxResult.Text);

            actionLog.AddLogEntry("Action Completed", "Copy");
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            actionLog.AddLogEntry("Button clicked", "Help");
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/bfnwkb3zqbdvkuq/User%20guide.pdf?dl=0");
        }
    }
}
