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
using Microsoft.Win32;
using System.IO;

namespace OpenFileDialogDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OpenFileDialog? openFileDialog;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, RoutedEventArgs e)
        {
            openFileDialog = new OpenFileDialog
            {
                //openFileDialog.InitialDirectory = @"C:\";
                //openFileDialog.InitialDirectory = System.IO.Path.GetFullPath(Environment.CurrentDirectory + @"\..\..\..");
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                myTextBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void SaveFileButton_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog == null)
                return;

            File.WriteAllText(openFileDialog.FileName, myTextBox.Text);
            openFileDialog = null;
            myTextBox.Text = string.Empty;
            MessageBox.Show("File saved successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
