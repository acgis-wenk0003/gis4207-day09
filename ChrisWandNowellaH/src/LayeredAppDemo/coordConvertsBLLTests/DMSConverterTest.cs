using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoordConverterBLL;

namespace coordConvertsBLLTests
{
    [TestClass]
    public class DMSConverterTest
    {
        [TestMethod]
        public void DMS2Dd_ValidCoords_Calculated()
        {
            //Arrange
            DMSCoord Coords = new DMSCoord();
            Coords.deg = 50;
            Coords.min = 11;
            Coords.sec = 11.1;
            Coords.quadrant= 0;
            DMSConverter target = new DMSConverter();
            string expected = "50.18642";

            //Act
            string actual =Convert.ToString( target.Dms2Dd(Coords));

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
