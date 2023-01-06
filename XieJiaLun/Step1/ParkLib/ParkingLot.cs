namespace ParkLib;

public class ParkingLot
{
    private int _parkCount;
    private readonly int _parkCapacity;

    public ParkingLot(int parkCapacity)
    {
        if (parkCapacity < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(parkCapacity));
        }

        _parkCapacity = parkCapacity;
        _parkCount = 0;
    }

    public bool ParkCar()
    {
        if (_parkCount < _parkCapacity)
        {
            _parkCount++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool PickUpCar()
    {
        if (_parkCount > 0)
        {
            _parkCount--;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsFull()
    {
        return Count == Capacity;
    }

    public int Capacity => _parkCapacity;

    public int Count => _parkCount;

    public int AvailableCount => _parkCapacity - _parkCount;
}