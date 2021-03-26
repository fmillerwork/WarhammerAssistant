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
    /// Logique d'interaction pour PaintStockView.xaml
    /// </summary>
    public partial class PaintStockView : UserControl
    {
        public PaintStockView()
        {
            InitializeComponent();
        }

        private void DisplayType_Checked(object sender, RoutedEventArgs e)
        {
            PaintLBbyRef.Visibility = Visibility.Visible;
            PaintLBbyID.Visibility = Visibility.Collapsed;
        }

        private void DisplayType_Unchecked(object sender, RoutedEventArgs e)
        {
            PaintLBbyRef.Visibility = Visibility.Collapsed;
            PaintLBbyID.Visibility = Visibility.Visible;
        }

        #region Events Tri
        private void AlphabeticSortRB_Checked(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainStockViewModel vm)
            {
                vm.AlphabeticPaintSort((bool)AescendingRB.IsChecked); 
                UpdateListItemsSource(vm);
            }
        }

        private void ColorSortRB_Checked(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainStockViewModel vm)
            {
                vm.ColorPaintSort((bool)AescendingRB.IsChecked);
                UpdateListItemsSource(vm);
            }
        }

        private void FilledSortRB_Checked(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainStockViewModel vm)
            {
                vm.FilledPaintSort((bool)AescendingRB.IsChecked);
                UpdateListItemsSource(vm);
            }
        }

        private void TypeSortRB_Checked(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainStockViewModel vm)
            {
                vm.TypePaintSort((bool)AescendingRB.IsChecked);
                UpdateListItemsSource(vm);
            }
        }

        private void AescendingRB_Checked(object sender, RoutedEventArgs e)
        {
            AscendingDescendingSort(true);
        }

        private void DescendingRB_Checked(object sender, RoutedEventArgs e)
        {
            AscendingDescendingSort(false);
        }

        #region Sous Méthodes de Tri
        private void UpdateListItemsSource(MainStockViewModel vm)
        {
            PaintLBbyID.ItemsSource = vm.Paints;
            PaintLBbyRef.ItemsSource = vm.Paints;
        }
        private void AscendingDescendingSort(bool ascending)
        {
            if (DataContext is MainStockViewModel vm)
            {
                if ((bool)AlphabeticSortRB.IsChecked)
                    vm.AlphabeticPaintSort(ascending);
                else if ((bool)ColorSortRB.IsChecked)
                    vm.ColorPaintSort(ascending);
                else if ((bool)FilledSortRB.IsChecked)
                    vm.FilledPaintSort(ascending);
                else if ((bool)TypeSortRB.IsChecked)
                    vm.TypePaintSort(ascending);
                UpdateListItemsSource(vm);
            }
        }
        #endregion
       
        #endregion
    }
}
