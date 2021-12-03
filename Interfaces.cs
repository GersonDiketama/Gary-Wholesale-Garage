namespace Garage
{
    public interface IElectricVehicle
    {
        void ChargeBattery();
        int CurrentChargePercentage { get; }

    }

    public interface IGas
    {
        double CurrentTankPercentage { get; }
        void RefuelTank();
    }
}