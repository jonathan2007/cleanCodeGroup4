namespace ParkingLot;

public class ParkingAdministrator
{
    private readonly uint _maxParkingLotNum;
    private readonly List<ParkingLot> _parkingLots = new();

    public ParkingAdministrator() : this(2)
    {

    }

    protected ParkingAdministrator(uint maxParkingLotNum)
    {
        _maxParkingLotNum = maxParkingLotNum;
    }

    public bool TakeCharge(ParkingLot parkingLot)
    {
        if (_parkingLots.Count < _maxParkingLotNum)
        {
            _parkingLots.Add(parkingLot);
            return true;
        }

        return false;
    }

    public ParkingLot? GetAvailableParkingLot()
    {
        foreach (var parkingLot in _parkingLots)
        {
            if (parkingLot.EmptyParkingSpotCount > 0)
                return parkingLot;
        }

        return null;
    }
}
