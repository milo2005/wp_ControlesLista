using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesLista.Models
{
    public class Menu
    {
        private ObservableCollection<ItemMenu> data;

        public ObservableCollection<ItemMenu> Data {
            get {
                if (data == null) {
                    data = new ObservableCollection<ItemMenu>();
                    ItemMenu item1 = new ItemMenu() { 
                        Titulo = "Panorama",
                        Descripción = "Ejemplo de Panorama"
                    };

                    ItemMenu item2 = new ItemMenu()
                    {
                        Titulo = "Pivot",
                        Descripción = "Ejemplo de Pivot"

                    };

                    data.Add(item1);
                    data.Add(item2);

                }

                return data;

            }

            set{
                data = value;
            }
        }

    }
}
