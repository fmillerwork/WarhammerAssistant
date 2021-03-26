using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warhammer_Assistant.Model;

namespace Warhammer_Assistant.ViewModel.Stock
{
    public class BrushStockViewModel : Observable
    {
        #region Champs
        private readonly Brush _model;
        public string Label
        {
            get => _model.Label;
            set { _model.Label = value; OnPropertyChanged(nameof(Label)); }
        }

        public string State
        {
            get => _model.State;
            set { _model.State = value; OnPropertyChanged(nameof(State)); }
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

        public BrushStockViewModel(Brush model)
        {
            _model = model;
        }
    }
}
