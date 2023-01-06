namespace ParkExtensionLib.Tests
{
    public class ParkManagerTest
    {
        [Fact]
        public void ParkManager_Park_Should()
        {
            var parkManager = new ParkManager(10,10);
            for (int i = 0; i < 11; i++)
            {
                parkManager.Park();
            }

            Assert.Equal(10, parkManager.Park1Count);
            Assert.Equal(1, parkManager.Park2Count);
        }
    }
}