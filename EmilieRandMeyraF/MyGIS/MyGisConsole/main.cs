using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGISBLL;

namespace MyGisConsole
{
    class main
    {
        private static object map;

        static void Main(string[] args)
        {
            Map mapCanada = new Map();
            mapCanada.Name = "Canada";
            Console.WriteLine("Map: {0}", mapCanada.Name);

            Layer layerOntario = new Layer();
            layerOntario.Name = "Ontario";
            Layer layerManitoba = new Layer();
            layerManitoba.Name = "Manitoba";
            Layer layerAlberta = new Layer();
            layerAlberta.Name = "Alberta";

            mapCanada.AddLayer(layerOntario);
            mapCanada.AddLayer(layerManitoba);
            mapCanada.AddLayer(layerAlberta);

            mapCanada.GetLayer(0);
            mapCanada.GetLayerByName("Ontario");
            //Console.WriteLine("     Layer{0}: {1}", .Layers, .Name);
       
            mapCanada.GetLayer(1);
            mapCanada.GetLayerByName("Manitoba");
            Console.WriteLine("{0}", x);

            mapCanada.GetLayer(2);
            mapCanada.GetLayerByName("Alberta");
            Console.WriteLine("", layerAlberta);

            Console.ReadKey();
        }
        
    }
}
