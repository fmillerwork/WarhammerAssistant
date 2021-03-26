using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warhammer_Assistant.Model;

namespace Warhammer_Assistant.ViewModel.Stock
{
    public class MainStockViewModel
    {
        public ObservableCollection<PaintStockViewModel> Paints { get; set; }
        public ObservableCollection<BrushStockViewModel> Brushes { get; set; }

        public MainStockViewModel()
        {
            Paints = new ObservableCollection<PaintStockViewModel>(){
                //Test
                new PaintStockViewModel(new Paint("1/4", "Base", "Rouge",3.2f,5011921026210, "Khorne Red")),
                new PaintStockViewModel(new Paint("1/2", "Layer", "Orange",3.2f,5011921026708, "Zquig Orange")),
                new PaintStockViewModel(new Paint("1/2", "Layer", "Orange",3.2f,5011921026708, "Aquig Orange")),
                new PaintStockViewModel(new Paint("1/2", "Layer", "Orange",3.2f,5011921026708, "Gquig Orange"))
            };

            Brushes = new ObservableCollection<BrushStockViewModel>(){
                //Test
                new BrushStockViewModel(new Brush("Bon", 3.2f,5011921026210, "Layer M")),
                new BrushStockViewModel(new Brush("Moyen", 3.2f,5011921026210, "Base S")),
                new BrushStockViewModel(new Brush("Bon", 3.2f,5011921026210, "Layer M")),
                new BrushStockViewModel(new Brush("Moyen", 3.2f,5011921026210, "Base S"))
            };
        }

        #region Méthode de tri
        public void AlphabeticPaintSort(bool ascending)
        {
            if(ascending)
                Paints = new ObservableCollection<PaintStockViewModel>(Paints.OrderBy(x => x.Label).ToList());
            else
                Paints = new ObservableCollection<PaintStockViewModel>(Paints.OrderByDescending(x => x.Label).ToList());
        }
        
        public void ColorPaintSort(bool ascending)
        {
            if (ascending)
                Paints = new ObservableCollection<PaintStockViewModel>(Paints.OrderBy(x => x.Color));
            else
                Paints = new ObservableCollection<PaintStockViewModel>(Paints.OrderByDescending(x => x.Color));
        }

        public void TypePaintSort(bool ascending)
        {
            if (ascending)
                Paints = new ObservableCollection<PaintStockViewModel>(Paints.OrderBy(x => x.Type));
            else
                Paints = new ObservableCollection<PaintStockViewModel>(Paints.OrderByDescending(x => x.Type));
        }

        public void FilledPaintSort(bool ascending)
        {
            if (ascending)
                Paints = new ObservableCollection<PaintStockViewModel>(Paints.OrderBy(x => x.FilledLv));
            else
                Paints = new ObservableCollection<PaintStockViewModel>(Paints.OrderByDescending(x => x.FilledLv));
        }

        public void AlphabeticBrushSort(bool ascending)
        {
            if (ascending)
                Brushes = new ObservableCollection<BrushStockViewModel>(Brushes.OrderBy(x => x.Label).ToList());
            else 
                Brushes = new ObservableCollection<BrushStockViewModel>(Brushes.OrderByDescending(x => x.Label).ToList());
        }

        public void StateBrushSort(bool ascending)
        {
            if (ascending)
                Brushes = new ObservableCollection<BrushStockViewModel>(Brushes.OrderBy(x => x.State).ToList());
            else
                Brushes = new ObservableCollection<BrushStockViewModel>(Brushes.OrderByDescending(x => x.State).ToList());
        }
        #endregion
    }
}
