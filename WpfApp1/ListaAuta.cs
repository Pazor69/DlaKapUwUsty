using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class ListaAuta
    {
        public ObservableCollection<Auta> auta;
        public ListaAuta() {
            auta=new ObservableCollection<Auta>();

        }
        public void AddAuto(Auta auta)
        {

        }
    }
}
