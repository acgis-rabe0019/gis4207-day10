using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGISBLL
{
    public class Map
    {
        private string name = "N/A";

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public readonly Layer[] Layers = new Layer[];
        public Layer[] Layers
        {
            get
            {
                return Layers;
            }
        }

    }
}

