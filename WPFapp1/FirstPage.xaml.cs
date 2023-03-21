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
using WPFapp1.fovorite_colorDataSetTableAdapters;

namespace WPFapp1
{
    /// <summary>
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        colorsTableAdapter colours = new colorsTableAdapter();
        public FirstPage()
        {
            InitializeComponent();
            ColoursDataGrid.ItemsSource = colours.GetData();
            ColoursDataGrid.DisplayMemberPath = "color_name";
        }
    }
}
