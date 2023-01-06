namespace Park.Test;

public class ParkTest
{
    [Fact]
    public void CarInit()
    {
        var car = new Car("Car1");
        Assert.Equal("Car1", car.Id);
    }

    [Fact]
    public void CarInitThrow()
    {
        Assert.Throws<ArgumentNullException>(() => new Car(string.Empty));
    }

    [Fact]
    public void ParkInit()
    {
        var park = new Park(3);
        Assert.Equal(3, park.Margin);
    }

    [Fact]
    public void ParkInitThrow()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Park(-10));
    }

    [Fact]
    public void ParkCar()
    {
        var park = new Park(3);
        Assert.True(park.ParkCar(new Car("Car1")));
        Assert.Equal(2,park.Margin);
    }

    [Fact]
    public void ParkCarFalse()
    {
        var park = new Park(3);
        for (int i = 0; i < 2; i++)
        {
            park.ParkCar(new Car($"Car{i}"));
        }
        Assert.False(park.ParkCar(new Car("Car1")));
        park.ParkCar(new Car("Car2"));
        Assert.False(park.ParkCar(new Car("Car3")));
    }

    [Fact]
    public void PickUp()
    {
        var park = new Park(3);
        for (int i = 0; i < 3; i++)
        {
            park.ParkCar(new Car($"Car{i}"));
        }

        Assert.True(park.PickUp("Car1"));
        Assert.Equal(1, park.Margin);
    }

    [Fact]
    public void PickUpFalse()
    {
        var park = new Park(3);
        Assert.False(park.PickUp("Car3"));
        for (int i = 0; i < 3; i++)
        {
            park.ParkCar(new Car($"Car{i}"));
        }
        Assert.False(park.PickUp(string.Empty));
        Assert.False(park.PickUp("Car3"));
    }
}