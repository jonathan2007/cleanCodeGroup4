namespace ParkingLot;

public class ParkingLot
{
    private readonly uint _capacity;

    public uint EmptyParkingSpotCount { get; private set; }

    private ParkingLot(uint capacity)
    {
        _capacity = capacity;
        EmptyParkingSpotCount = capacity;
    }

    public static ParkingLot? Build(uint capacity)
    {
        if (capacity > 0)
            return new ParkingLot(capacity);

        return null;
    }

    public bool Park()
    {
        if (EmptyParkingSpotCount <= 0)
            return false;

        EmptyParkingSpotCount--;
        return true;
    }

    public bool UnPark()
    {
        if (EmptyParkingSpotCount >= _capacity)
            return false;

        EmptyParkingSpotCount++;
        return true;
    }
}