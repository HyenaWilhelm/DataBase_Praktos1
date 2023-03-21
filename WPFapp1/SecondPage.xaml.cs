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
    /// Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        favourite_colorTableAdapter colours = new favourite_colorTableAdapter();
        public SecondPage()
        {
            InitializeComponent();
            FvColoursDataGrid.ItemsSource = colours.GetData();
            FvColoursDataGrid.DisplayMemberPath = "fv_name"; 
            FvColoursDataGrid.DisplayMemberPath = "Color_ID";
        }
    }
}
