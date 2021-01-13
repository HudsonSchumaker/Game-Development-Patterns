using UnityEngine;

// Hudson Schumaker

public class CarPartShutdownVisitor : ICarPartVisitor
{
    public void Visit(Car car)
    {
        Debug.Log("Car is off.");
    }
    
    public void Visit(Battery battery)
    {
        Debug.Log("Battery is not charged.");
    }
}
