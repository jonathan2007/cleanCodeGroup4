namespace Park;

/// <summary>
/// 车模型类
/// </summary>
public class Car
{
    /// <summary>
    /// 车牌
    /// </summary>
    public string Id { get; }

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="id"></param>
    public Car(string id)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentNullException("请传入正确的车牌");
        }

        Id = id;
    }
}