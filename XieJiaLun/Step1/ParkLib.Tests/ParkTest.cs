namespace ParkLib.Tests;

public class ParkTest
{
    [Fact]
    public void Park_Init_Should()
    {
        var park = new ParkingLot(10);

        Assert.Equal(10, park.Capacity);
        Assert.Equal(0, park.Count);
        Assert.Equal(10,park.AvailableCount);
    }

    [Fact]
    public void Park_Init_ShouldNot()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new ParkingLot(-10));
    }

    [Fact]
    public void Park_ParkCar_Should()
    {
        var park = new ParkingLot(10);
        var result = park.ParkCar();
        Assert.Equal(1, park.Count);
        Assert.Equal(9, park.AvailableCount);
        Assert.True(result);
    }

    [Fact]
    public void Park_ParkCar_ShouldNot()
    {
        var park = new ParkingLot(1);
        park.ParkCar();
        var result = park.ParkCar();
        Assert.False(result);
    }

    [Fact]
    public void Park_PickUpCar_Should()
    {
        var park = new ParkingLot(10);
        park.ParkCar();
        var result = park.PickUpCar();
        Assert.Equal(0, park.Count);
        Assert.True(result);
    }

    [Fact]
    public void Park_PickUpCar_ShouldNot()
    {
        var park = new ParkingLot(10);
        var result = park.PickUpCar();
        Assert.False(result);
    }

    [Fact]
    public void Park_IsFull_Should()
    {
        var park = new ParkingLot(10);
        for (int i = 0; i < 10; i++)
        {
            park.ParkCar();
        }
        Assert.True(park.IsFull());
    }
}