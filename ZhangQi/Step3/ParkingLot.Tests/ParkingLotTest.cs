namespace ParkingLot.Tests;

public class ParkingLotTest
{
    [Fact]
    public void Build_ReturnNull()
    {
         var lot = ParkingLot.Build(0);
         Assert.Null(lot);
    }

    [Fact]
    public void Build_ReturnNormal()
    {
        var lot = ParkingLot.Build(10);
        Assert.NotNull(lot);
    }

    [Fact]
    public void Park_Success()
    {
        var lot = ParkingLot.Build(10);
        Assert.True(lot!.Park());
    }

    [Fact]
    public void Park_Fail()
    {
        var lot = ParkingLot.Build(1);
        lot!.Park();
        Assert.False(lot!.Park());
    }

    [Fact]
    public void UnPark_Success()
    {
        var lot = ParkingLot.Build(1);
        lot!.Park();
        Assert.True(lot!.UnPark());
    }

    [Fact]
    public void UnPark_Fail()
    {
        var lot = ParkingLot.Build(1);
        lot!.Park();
        lot!.UnPark();
        Assert.False(lot!.UnPark());
    }
}
