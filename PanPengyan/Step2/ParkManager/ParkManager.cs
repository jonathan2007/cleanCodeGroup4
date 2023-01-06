using Park;

namespace ParkManager;

/// <summary>
/// 停车场管理类
/// </summary>
public class ParkManager
{
    private Park.Park _park1;
    private Park.Park _park2;

    public int Park1Margin => _park1.Margin;
    public int Park2Margin => _park2.Margin;

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="park1"></param>
    /// <param name="park2"></param>
    public ParkManager(Park.Park park1, Park.Park park2)
    {
        _park1 = park1;
        _park2 = park2;
    }


    /// <summary>
    /// 停车
    /// </summary>
    /// <param name="car"></param>
    /// <returns></returns>
    public bool ParkCar(Car car)
    {
        var park = ParkCarGetPark(car.Id);
        if (park == null)
        {
            return false;
        }

        return park.ParkCar(car);
    }

    /// <summary>
    /// 取车
    /// </summary>
    /// <param name="carId"></param>
    /// <returns></returns>
    public bool PickUp(string carId)
    {
        var park = PickUpGetPark(carId);
        if (park == null)
        {
            return false;
        }

        return park.PickUp(carId);
    }

    private Park.Park? ParkCarGetPark(string carId)
    {
        if (_park1.Margin > 0 && !_park1.IsHasCar(carId))
        {
            return _park1;
        }
        else if (_park2.Margin > 0 && !_park2.IsHasCar(carId))
        {
            return _park2;
        }

        return null;
    }

    private Park.Park? PickUpGetPark(string carId)
    {
        if (_park1.IsHasCar(carId))
        {
            return _park1;
        }
        else if (_park2.IsHasCar(carId))
        {
            return _park2;
        }

        return null;
    }
}