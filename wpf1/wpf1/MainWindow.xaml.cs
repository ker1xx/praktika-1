using System.Data;
using System.Windows;
using wpf1.DataSet1TableAdapters;
using System.Windows.Documents;
using System.Collections.Generic;
using System.Windows.Markup;

namespace wpf1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        teachersTableAdapter table1 = new teachersTableAdapter();
        practiseTableAdapter table2 = new practiseTableAdapter();
        disciplinesTableAdapter table3 = new disciplinesTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void tab1_Click(object sender, RoutedEventArgs e)
        {
            tab1 tab1 = new tab1();
            tab1.Table.ItemsSource = table1.GetData();
            tab1.Show();
        }

        private void tab2_Click(object sender, RoutedEventArgs e)
        {
            tab2 tab2 = new tab2();
            tab2.Table.ItemsSource = table2.GetData();
            tab2.Show();
        }

        private void tab3_Click(object sender, RoutedEventArgs e)
        {
            tab3 tab3 = new tab3();
            tab3.Table.ItemsSource = table3.GetData();
            tab3.Show();
        }
    }
}
