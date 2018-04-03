using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGISBLL;

namespace MyGisConsole
{
    class Program
    {
        private static object map;

        static void Main(string[] args)
        {
            Map mapCanada = new Map();
            mapCanada.Name = "Canada";


            Layer layerOntario = new Layer();
            layerOntario.Name = "Ontario";
            Layer Manitoba = new Layer();
            Manitoba.Name = "Manitoba";
            Layer layerAlberta = new Layer();
            layerAlberta.Name = "Alberta";

            mapCanada.AddLayer(layerOntario);
            mapCanada.AddLayer(Manitoba);
            mapCanada.AddLayer(layerAlberta);
   
            mapCanada.GetLayer(1);
            mapCanada.GetLayerByName("Manitoba");
            Console.WriteLine("{0}", mapCanada.GetLayer(1).Name);
            Console.WriteLine("{0}", mapCanada.GetLayerByName("Manitoba").Name);
            Console.WriteLine("Map: {0}", mapCanada.Name);
            Console.WriteLine("     Layer {0}: {1}", 0, mapCanada.Layers[0].Name);
            Console.WriteLine("     Layer {0}: {1}", 1, mapCanada.Layers[1].Name);
            Console.WriteLine("     Layer {0}: {1}", 2, mapCanada.Layers[2].Name);
            

            Console.WriteLine(mapCanada.GetLayerByName("Manitoba").Name);
            mapCanada.GetLayer(22);

            int lyrindex = 45;
            if (mapCanada.GetLayer(lyrindex) != null) ;

            Console.ReadKey();
        }
        
    }
}
