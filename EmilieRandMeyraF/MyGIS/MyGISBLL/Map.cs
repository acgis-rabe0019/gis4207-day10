﻿using System;
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

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Layer[] Layers { get { return _layers; } }

        public int LayerCount { get { return _layerCount; } }

        public void AddLayer(Layer layer)
        {
            Array.Resize(ref _layers, _layers.Length + 1);
            _layers[_layers.Length - 1] = layer;
            _layerCount++;

        }

        public Layer GetLayer(int layerIndex)
        {
            return _layers[layerIndex];
        }

        public Layer GetLayerByName(string layerName)
        {
            Layer layer = null;
            // Code for finding layer by name
            // Loop your list of layer names to see if you 
            // can find layerName
            foreach (Layer lyr in Layers)
            {
                // If it exists, return the layer with the name layerName
                if (lyr.Name == layerName)
                    return lyr;
            }

            // If it doesn't, return null
            return layer;
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


