using System;
using System.Collections;
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

namespace SortedListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;

        string data = "All Data : \n";
        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            sortedList.Add(txtKey.Text, txtValue.Text);

            txtKey.Clear();
            txtValue.Clear();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            ICollection collection = sortedList.Keys;

            foreach (string key in collection)
            {
                //MessageBox.Show(sortedList[key].ToString());

                data = data + sortedList[key].ToString() + "\n";
            }

            MessageBox.Show(data);
        }
    }
}
