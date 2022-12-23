using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTestRoomNumber
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RoomNumber rn = new RoomNumber();
            rn.numberOfSets();
            //First test testing input value 122 expected 2
      
        }
    }
}
