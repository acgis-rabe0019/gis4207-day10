using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyGISBLL;

namespace MYGisBLLTests
{
    [TestClass]
    public class MapTest
    {
        [TestMethod]
        public void AddLayerTest()
        {
            //Arrange
            Map map = new Map();
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
    }
}
