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
using Warhammer_Assistant.ViewModel.Stock;

namespace Warhammer_Assistant.View.Stock
{
    /// <summary>
    /// Logique d'interaction pour MainStockView.xaml
    /// </summary>
    public partial class MainStockView : UserControl
    {
        public MainStockView()
        {
            InitializeComponent();
            DataContext = new MainStockViewModel();
        }

    }
}
