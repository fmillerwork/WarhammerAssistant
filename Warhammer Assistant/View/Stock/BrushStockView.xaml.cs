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
    /// Logique d'interaction pour BrushStockView.xaml
    /// </summary>
    public partial class BrushStockView : UserControl
    {
        public BrushStockView()
        {
            InitializeComponent();
        }

        private void DisplayType_Checked(object sender, RoutedEventArgs e)
        {
            BrushLBbyRef.Visibility = Visibility.Visible;
            BrushLBbyID.Visibility = Visibility.Collapsed;
        }

        private void DisplayType_Unchecked(object sender, RoutedEventArgs e)
        {
            BrushLBbyRef.Visibility = Visibility.Collapsed;
            BrushLBbyID.Visibility = Visibility.Visible;
        }

        #region Events Tri
        private void AlphabeticSortRB_Checked(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainStockViewModel vm)
            {
                vm.AlphabeticBrushSort((bool)AescendingRB.IsChecked);
                UpdateListItemsSource(vm);
            }
        }

        private void StateSortRB_Checked(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainStockViewModel vm)
            {
                vm.StateBrushSort((bool)AescendingRB.IsChecked);
                UpdateListItemsSource(vm);
            }
        }

        private void AscendingRB_Checked(object sender, RoutedEventArgs e)
        {
            AscendingDescendingSort(true);
        }

        private void DescendingRB_Checked(object sender, RoutedEventArgs e)
        {
            AscendingDescendingSort(false);
        }

        #region Méthodes Privées
        private void UpdateListItemsSource(MainStockViewModel vm)
        {
            BrushLBbyID.ItemsSource = vm.Brushes;
            BrushLBbyRef.ItemsSource = vm.Brushes;
        }

        private void AscendingDescendingSort(bool ascending)
        {
            if (DataContext is MainStockViewModel vm)
            {
                if ((bool)AlphabeticSortRB.IsChecked)
                    vm.AlphabeticBrushSort(ascending);
                else if ((bool)StateSortRB.IsChecked)
                    vm.StateBrushSort(ascending);
                UpdateListItemsSource(vm);
            }
        }
        #endregion

        #endregion
    }
}
