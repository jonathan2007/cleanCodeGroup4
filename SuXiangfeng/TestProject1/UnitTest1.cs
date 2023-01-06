using NUnit.Framework;
using Sample1;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            uint capacity1 = 5;
            uint capacity2 = 5;
            ParkingLot lot1 = ParkingLot.CreateObjectWithCapacity(capacity1);
            ParkingLot lot2 = ParkingLot.CreateObjectWithCapacity(capacity2);

            ParkingBoy boy1 = ParkingBoy.CreateObject(1, lot1, lot2);

            uint expect1 = capacity1;
            uint expect2 = capacity2;
            do
            {
                boy1.Park();

                expect1--;
                if (expect1 == 0)
                {
                    expect2--;
                }

                Assert.AreEqual(expect1, lot1.Available);
                Assert.AreEqual(expect2, lot2.Available);
            } while (lot1.Available == 0 && lot2.Available == 0);
        }

        [Test]
        public void Test2()
        {
            uint capacity1 = 5;
            uint capacity2 = 5;
            ParkingLot lot1 = ParkingLot.CreateObjectWithCapacity(capacity1);
            ParkingLot lot2 = ParkingLot.CreateObjectWithCapacity(capacity2);

            ParkingBoy boy2 = ParkingBoy.CreateObject(2, lot1, lot2);

            uint expect1 = capacity1;
            uint expect2 = capacity2;

            int i = 0;
            do
            {
                boy2.Park();

                if (i % 2 == 0)
                {
                    expect1--;
                }
                else
                {
                    expect2--;
                }

                i++;

                Assert.AreEqual(expect1, lot1.Available);
                Assert.AreEqual(expect2, lot2.Available);
            } while (lot1.Available == 0 && lot2.Available == 0);
        }

        [Test]
        public void Test3()
        {
            uint capacity1 = 5;
            uint capacity2 = 5;
            ParkingLot lot1 = ParkingLot.CreateObjectWithCapacity(capacity1);
            ParkingLot lot2 = ParkingLot.CreateObjectWithCapacity(capacity2);

            ParkingBoy boy3 = ParkingBoy.CreateObject(3, lot1, lot2);

            uint expect1 = capacity1;
            uint expect2 = capacity2;
            do
            {
                boy3.Park();

                expect1--;
                if (expect1 == 0)
                {
                    expect2--;
                }

                Assert.AreEqual(expect1, lot1.Available);
                Assert.AreEqual(expect2, lot2.Available);
            } while (lot1.Available == 0 && lot2.Available == 0);
        }
    }
}