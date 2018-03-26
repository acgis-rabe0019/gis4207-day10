using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGISBLL
{
    public class Map

    {
        private Layer[] _layers = new Layer[0];
        private int _layerCount = 0;
        public int layerIndex = 0;


        public string Name { get; set; }
        public Layer[] Layers {get { return _layers; }}

        public int LayerCount { get { return _layerCount; } }

        

        public void AddLayer(Layer layer)
        {
            Array.Resize(ref _layers, _layers.Length + 1);
            _layers[_layers.Length - 1] = layer;
            _layerCount++;
               
        }
        public void GetLayer (Layer layerIndex)
        {
            Array.IndexOf (_layers, layerIndex);
            layerIndex = 10;
        }
        
        
        


    }

}


