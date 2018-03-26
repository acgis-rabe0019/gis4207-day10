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
        static void Main(string[] args)
        {

            Map mapCanada = new Map();
            mapCanada.Name = "Canada";
            Layer layerOntario = new Layer();
            layerOntario.Name = "Ontario";
           
            Layer layerManitoba = new Layer();
            layerManitoba.Name = "Manitoba";
            Layer layerAlberta = new Layer();
            layerAlberta.Name = "Alberta";

            mapCanada.AddLayer(layerOntario);
            mapCanada.AddLayer(layerManitoba);
            mapCanada.AddLayer(layerAlberta);

            mapCanada.GetLayer(1);
            Console.WriteLine("", layerManitoba);
            mapCanada.GetLayerByName("Manitoba");
            Console.WriteLine("",layerManitoba);

            mapCanada.GetLayer(0);
            Console.WriteLine("", layerOntario);
            mapCanada.GetLayerByName("Ontario");
            Console.WriteLine("", layerOntario);

            mapCanada.GetLayer(1);
            Console.WriteLine("", layerManitoba);
            mapCanada.GetLayerByName("Manitoba");
            Console.WriteLine("", layerManitoba);

            mapCanada.GetLayer(2);
            Console.WriteLine("", layerAlberta);
            mapCanada.GetLayerByName("Alberta");
            Console.WriteLine("", layerAlberta);





        }
       
    }
}
