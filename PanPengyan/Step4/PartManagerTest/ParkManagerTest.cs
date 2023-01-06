using Park;

namespace ParkManagerTest;

public class ParkManagerTest
{
    [Fact]
    public void InitTest()
    {
        var parkManager = new ParkManager.ParkManager(new Park.Park(1), new Park.Park(2));
        Assert.Equal(1, parkManager.Park1Margin);
        Assert.Equal(2, parkManager.Park2Margin);
    }

    [Fact]
    public void ParkCar()
    {
        var parkManager = new ParkManager.ParkManager(new Park.Park(1), new Park.Park(2));
        Assert.True(parkManager.ParkCar(new Car("Car1")));
        Assert.Equal(0, parkManager.Park1Margin);
        Assert.True(parkManager.ParkCar(new Car("Car2")));
        Assert.Equal(1, parkManager.Park2Margin);
    }

    [Fact]
    public void ParkCarFalse()
    {
        var parkManager = new ParkManager.ParkManager(new Park.Park(1), new Park.Park(2));
        for (int i = 0; i < 3; i++)
        {
            Assert.True(parkManager.ParkCar(new Car($"Car{i}")));
        }
        Assert.False(parkManager.ParkCar(new Car("Car1")));
        Assert.False(parkManager.ParkCar(new Car("Car3")));
    }

    [Fact]
    public void PickUp()
    {
        var parkManager = new ParkManager.ParkManager(new Park.Park(1), new Park.Park(2));
        for (int i = 0; i < 3; i++)
        {
            Assert.True(parkManager.ParkCar(new Car($"Car{i}")));
        }

        Assert.True(parkManager.PickUp("Car1"));
    }

    [Fact]
    public void PickUpFalse()
    {
        var parkManager = new ParkManager.ParkManager(new Park.Park(1), new Park.Park(2));
        for (int i = 0; i < 3; i++)
        {
            Assert.True(parkManager.ParkCar(new Car($"Car{i}")));
        }

        Assert.False(parkManager.PickUp("Car3"));
    }
}