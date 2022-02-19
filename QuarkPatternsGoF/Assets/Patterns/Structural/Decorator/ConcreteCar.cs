public class ConcreteCar : Car
{
    public ConcreteCar(string carBrand = "Chevrolet", string carModel = "Prisma", int speed = 120)
    {
        this.carBrand = carBrand;
        this.carModel = carModel;
        this.speed = speed;
    }

    public override string MaxSpeed()
    {

        return $"La velocidad maxima de este auto es {speed}";
    }
}
