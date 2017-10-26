using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace ExampleThree
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OpenFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                userTextBox.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void SaveFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, userTextBox.Text);
        }

        private void ExitAppMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CutTextMenuItem_Click(object sender, RoutedEventArgs e)
        {
                userTextBox.Cut();
        }

        private void CopyTextMenuItem_Click(object sender, RoutedEventArgs e)
        {
                userTextBox.Copy();
        }

        private void pasteTextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            userTextBox.Paste();
        }
    }
}
