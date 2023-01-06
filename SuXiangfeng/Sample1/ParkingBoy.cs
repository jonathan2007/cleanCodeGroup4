using System;

namespace Sample1
{
    public class ParkingBoy
    {
        private uint _strategy = 0;
        private ParkingLot _parkingLot1;
        private ParkingLot _parkingLot2;

        private ParkingBoy(uint strategy, ParkingLot lot1, ParkingLot lot2)
        {
            _strategy = strategy;
            _parkingLot1 = lot1;
            _parkingLot2 = lot2;
        }

        #region 
        public static ParkingBoy CreateObject(uint strategy, ParkingLot lot1, ParkingLot lot2)
        {
            ParkingBoy pBoy = new ParkingBoy(strategy, lot1, lot2);

            return pBoy;
        }
        #endregion

        #region Parking Strategy
        public void Park()
        {
            switch (_strategy)
            {
                case 1:
                    parkingStrategy1();
                    break;
                case 2:
                    parkingStrategy2();
                    break;
                case 3:
                    parkingStrategy3();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("strategy", "must be in [1,2,3]");
            }
        }

        private void parkingStrategy1()
        {
            if (_parkingLot1.Available > 0)
            {
                _parkingLot1.Park();
            }
            else
            {
                _parkingLot2.Park();
            }
        }
        private void parkingStrategy2()
        {
            uint available1 = _parkingLot1.Available;
            uint available2 = _parkingLot2.Available;

            if (available1 == 0 && available2 == 0)
            {
                throw new Exception("The parking lot is full");
            }

            if (available1 >= available2)
            {
                _parkingLot1.Park();
            }
            else
            {
                _parkingLot2.Park();
            }
        }
        private void parkingStrategy3()
        {
            uint available1 = _parkingLot1.Available;
            uint available2 = _parkingLot2.Available;

            if (available1 == 0 && available2 == 0)
            {
                throw new Exception("The parking lot is full");
            }

            if (available1 <= available2 && available1 != 0)
            {
                _parkingLot1.Park();
            }
            else
            {
                _parkingLot2.Park();
            }
        }
        #endregion
    }
}
