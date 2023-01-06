using ParkLib;

namespace ParkExtensionLib
{
    public class ParkManager
    {
        private readonly ParkingLot _park1;
        private readonly ParkingLot _park2;

        public ParkManager(int parkFirstCapacity,int parkSecondCapacity)
        {
            _park1 = new ParkingLot(parkFirstCapacity);
            _park2 = new ParkingLot(parkSecondCapacity);
        }

        public bool Park()
        {
            if (!_park1.IsFull())
            {
                return _park1.ParkCar();
            }
            else
            {
                return _park2.ParkCar();
            }
        }

        public int Park1Count => _park1.Count;

        public int Park2Count => _park2.Count;
    }
}