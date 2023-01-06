namespace Sample1
{
    public class ParkingLot
    {
        private uint _capacity = 10;
        private uint _count = 0;

        public uint Available => _capacity - _count;

        private ParkingLot(uint capacity)
        {
            _capacity = capacity;
        }

        #region CreateObjectWithCapacity
        public static ParkingLot CreateObjectWithCapacity(uint capacity)
        {
            ParkingLot parkingLot = new ParkingLot(capacity);

            return parkingLot;
        }
        #endregion

        #region Park
        public void Park()
        {
            _count++;
        }
        #endregion

        #region Leave
        public void Leave()
        {
            _count--;
        }
        #endregion 
    }
}
