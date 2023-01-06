namespace Park;

/// <summary>
/// 停车场
/// </summary>
public class Park
{
    /// <summary>
    /// 容量
    /// </summary>
    private readonly int _capacity;

    /// <summary>
    /// 存储的车辆
    /// </summary>
    private Dictionary<string, Car> _carDictionary = new Dictionary<string, Car>();

    /// <summary>
    /// 剩余容量
    /// </summary>
    public int Margin => _capacity - _carDictionary.Count;

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="capacity"></param>
    public Park(int capacity)
    {
        if (capacity <= 0)
        {
            throw new ArgumentOutOfRangeException("容量必须是正整数");
        }

        _capacity = capacity;
    }

    /// <summary>
    /// 停车
    /// </summary>
    /// <param name="car"></param>
    /// <returns></returns>
    public bool ParkCar(Car car)
    {
        if (Margin <= 0 || _carDictionary.ContainsKey(car.Id))
        {
            return false;
        }
        _carDictionary.Add(car.Id, car);
        return true;
    }

    /// <summary>
    /// 取车
    /// </summary>
    /// <param name="carId"></param>
    /// <returns></returns>
    public bool PickUp(string carId)
    {
        if (string.IsNullOrWhiteSpace(carId) || !_carDictionary.ContainsKey(carId))
        {
            return false;
        }

        return _carDictionary.Remove(carId);
    }

    /// <summary>
    /// 停车场内是否有这辆车
    /// </summary>
    /// <param name="carId"></param>
    /// <returns></returns>
    public bool IsHasCar(string carId)
    {
        if (string.IsNullOrWhiteSpace(carId) || !_carDictionary.ContainsKey(carId))
        {
            return false;
        }

        return true;
    }
}