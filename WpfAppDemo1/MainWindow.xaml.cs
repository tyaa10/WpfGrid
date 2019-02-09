using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfAppDemo1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> collection =
            new ObservableCollection<string>() { "str1", "str2", "str3" };
        public MainWindow()
        {
            InitializeComponent();
            stringsListBox.ItemsSource = collection;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string inputString = inputTextBox.Text;
            targetTextBlock.Text = inputString;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true) {
                MessageBox.Show(openFileDialog.FileName);
            }
        }
    }
}
