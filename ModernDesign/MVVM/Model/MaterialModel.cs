using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.MVVM.Model
{
    public class MaterialModel
    {
        public string MaterialName { get; set; }
        public bool IsFavorite { get; set; }
        public Action<object, PropertyChangedEventArgs> PropertyChanged { get; internal set; }
    }
}
