using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warhammer_Assistant.Model;

namespace Warhammer_Assistant.ViewModel.Stock
{
    public class PaintStockViewModel : Observable
    {
        #region Champs
        private readonly Paint _model;
        public string Label
        {
            get => _model.Label;
            set { _model.Label = value; OnPropertyChanged(nameof(Label)); }
        }

        public string FilledLv
        {
            get => _model.FilledLv;
            set { _model.FilledLv = value; OnPropertyChanged(nameof(FilledLv)); }
        }

        public string Type
        {
            get => _model.Type;
            set { _model.Type = value; OnPropertyChanged(nameof(Type)); }
        }

        public string Color
        {
            get => _model.Color;
            set { _model.Color = value; OnPropertyChanged(nameof(Color)); }
        }

        public long Ref
        {
            get => _model.Ref;
            set { _model.Ref = value; OnPropertyChanged(nameof(Ref)); }
        }

        public float Price
        {
            get => _model.Price;
            set { _model.Price = value; OnPropertyChanged(nameof(Price)); }
        }
        #endregion

        public PaintStockViewModel(Paint model)
        {
            _model = model;
        }
    }
}
