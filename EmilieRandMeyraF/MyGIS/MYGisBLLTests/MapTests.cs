using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyGISBLL;

namespace MYGisBLLTests
{
    [TestClass]
    public class MapTests
    {
        [TestMethod]
        public void AddLayerTest()
        {
            //Arrange
            Map map = new Map();
            map.Name = "My Map";
            string name = map.Name;
            Layer layerA = new Layer();
            layerA.Name = "Test1";
            Layer layerB = new Layer();
            layerB.Name = "Test2";

            //Act
            map.AddLayer(layerA);
            map.AddLayer(layerB);

            //Assert
            string actual = map.Layers[1].Name;

            Assert.AreEqual(layerB.Name, actual);
            Assert.AreEqual(2, map.LayerCount);
        }

        public void GetLayer_CheckSecondLayer_NameMatches()
        {
            //Arrange
            Map map = new Map();
            Layer layerA = new Layer();
            layerA.Name = "Test1";
            Layer layerB = new Layer();
            layerB.Name = "Test2";
            map.AddLayer(layerA);
            map.AddLayer(layerB);

            //Act
            Layer actual = map.GetLayer(1);

            //Assert
            Assert.AreEqual(layerB.Name, actual.Name);
        }

        public void GetLayerNameTest_GetName_NameExists()
        {
            //Arrange
            Map map = new Map();
            map.Name = "My Map";
            string name = map.Name;
            Layer layerA = new Layer();
            layerA.Name = "Test1";
            Layer layerB = new Layer();
            layerB.Name = "Test2";
            Layer layerC = new Layer();
            layerC.Name = "";
            map.AddLayer(layerA);
            map.AddLayer(layerB);
            map.AddLayer(layerC);


            //Act
            Layer actual = map.GetLayerByName("");

            //Assert
            Assert.AreEqual(layerC.Name, actual.Name);
            //Assert.AreEqual(layerA.Name, actual.Name);
            //Assert.AreEqual(layerB.Name, actual.Name);
        }

        public void RemoveLayer_CheckIndex_ResizeLayers()
        {
            //Arrange
            Map map = new Map();
            map.Name = "My Map";
            string name = map.Name;
            Layer layerA = new Layer();
            layerA.Name = "Test1";
            Layer layerB = new Layer();
            layerB.Name = "Test2";
            Layer layerC = new Layer();
            layerC.Name = "";
            map.AddLayer(layerA);
            map.AddLayer(layerB);
            map.AddLayer(layerC);


            //Act
            map.RemoveLayer(1);

            //Assert
            string actual = map.Layers[1].Name;

            Assert.AreEqual(layerB.Name, actual);
            Assert.AreEqual(2, map.LayerCount);

            //Arrange

            //Act

            //Assert
        }
    }
}
