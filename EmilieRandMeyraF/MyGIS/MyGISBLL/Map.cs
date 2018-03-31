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
        private string _name = "";

        // Properties of Map class: Name, Layers, LayerCount
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Layer[] Layers
        {
            get { return _layers; }
        }

        public int LayerCount
        {
            get { return _layerCount; }
        }

        // Methods of the Map class: AddLayer, GetLayer, GetLayerByName, RemoveLayer
        public void AddLayer(Layer layer)
        {
            Array.Resize(ref _layers, _layers.Length + 1);
            _layers[_layers.Length - 1] = layer;
            _layerCount++;
        }

        public Layer GetLayer(int layerIndex)
        {
                try
                {
                    return _layers[layerIndex];
                }

                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    return null;  
               }
            
            
        }

        public Layer GetLayerByName(string layerName)
        // Code for finding layer by name
        // Loop your list of layer names to see if you 
        // can find layerName
        // If it exists, return the layer with the name layerName
        // If it doesn't, return null

        {
            Layer layer = null;
            foreach (Layer lyr in Layers)
            {
                if (lyr.Name == layerName)
                    return lyr;
            }
            return layer;
        }

        public object GetLayerByName(object layerManitoba)
        {
            throw new NotImplementedException();
        }

        public void RemoveLayer(int layerIndex)
        {
            Layer layer = null;
            if (LayerCount > LayerCount-1)
                _layers[_layers.Length - 1] = layer;
                _layerCount--;
                Array.Resize(ref _layers, _layers.Length - 1);
        }
    }
}


