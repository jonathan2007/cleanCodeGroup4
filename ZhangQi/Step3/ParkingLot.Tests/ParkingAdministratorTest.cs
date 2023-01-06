namespace ParkingLot.Tests;

public class ParkingAdministratorTest
{
    [Fact]
    public void TakeCharge_Success()
    {
        var admin = new ParkingAdministrator();

        var lot1 = ParkingLot.Build(10);
        var lot2 = ParkingLot.Build(20);
        admin.TakeCharge(lot1!);
        Assert.True(admin.TakeCharge(lot2!));
    }

    [Fact]
    public void TakeCharge_Fail()
    {
        var admin = new ParkingAdministrator();

        var lot1 = ParkingLot.Build(10);
        var lot2 = ParkingLot.Build(20);
        var lot3 = ParkingLot.Build(20);
        admin.TakeCharge(lot1!);
        admin.TakeCharge(lot2!);
        Assert.False(admin.TakeCharge(lot3!));
    }

    [Fact]
    public void GetAvailableParkingLot_ReturnNull()
    {
        var admin = new ParkingAdministrator();

        var lot1 = ParkingLot.Build(2);
        var lot2 = ParkingLot.Build(2);
        admin.TakeCharge(lot1!);
        admin.TakeCharge(lot2!);

        lot1!.Park();
        lot1.Park();
        lot2!.Park();
        lot2.Park();

        Assert.Null(admin.GetAvailableParkingLot());
    }

    [Fact]
    public void GetAvailableParkingLot_ReturnNormal()
    {
        var admin = new ParkingAdministrator();

        var lot1 = ParkingLot.Build(3);
        var lot2 = ParkingLot.Build(3);
        admin.TakeCharge(lot1!);
        admin.TakeCharge(lot2!);

        lot1!.Park();
        lot2!.Park();
        lot2.Park();

        Assert.Equal(admin.GetAvailableParkingLot(), lot1);
    }
}
