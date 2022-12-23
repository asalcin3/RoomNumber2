using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestRoomNumber
{
    [TestClass]
    public class UnitTest1
    {
        private readonly RoomNumber? _roomNumber = new RoomNumber();
        
        [TestMethod]
        public void TestingValue122()
        {

            Assert.AreEqual(expected: _roomNumber.numberOfSets(122), actual: 2);
        }
        

        [TestMethod]
        public void TestingValue9999()
        {
            Assert.AreEqual(expected: _roomNumber.numberOfSets(9999), actual: 2);
        }

        [TestMethod]
        public void TestingValue12635()
        {
            Assert.AreEqual(expected: _roomNumber.numberOfSets(12635), actual: 1);
        }

        [TestMethod]
        public void TestingValue888888()
        {
            Assert.AreEqual(expected: _roomNumber.numberOfSets(888888), actual: 6);
        }

        [TestMethod]
        public void TestingNegativeValue()
        {
            Assert.AreEqual(expected: _roomNumber.numberOfSets(-122), actual: 0);
        }

 
    }
}