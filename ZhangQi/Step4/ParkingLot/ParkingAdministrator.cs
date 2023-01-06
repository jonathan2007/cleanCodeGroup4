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

    public bool Park()
    {
        var availableParkingLot = GetAvailableParkingLot();
        if (availableParkingLot == null)
            return false;

        return availableParkingLot.Park();
    }

    public bool UnPark()
    {
        var availableParkingLot = GetAvailableParkingLot();
        if (availableParkingLot == null)
            return false;

        return availableParkingLot.UnPark();
    }

    public ParkingLot? GetAvailableParkingLot()
    {
        return GetParkingLotByMinEmptySpot();
    }

    private ParkingLot? GetParkingLotByMinEmptySpot()
    {
        uint? minEmptyCount = null;
        ParkingLot? availableParkingLot = null;
        foreach (var parkingLot in _parkingLots)
        {
            minEmptyCount ??= parkingLot.EmptyParkingSpotCount;

            if (parkingLot.EmptyParkingSpotCount < minEmptyCount &&
                parkingLot.EmptyParkingSpotCount > 0)
            {
                minEmptyCount = parkingLot.EmptyParkingSpotCount;
                availableParkingLot = parkingLot;
            }
        }

        return availableParkingLot;
    }
}
