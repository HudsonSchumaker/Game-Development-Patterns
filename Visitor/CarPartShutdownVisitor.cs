using UnityEngine;

// Hudson Schumaker

public class CarPartShutdownVisitor : ICarPartVisitor
{
    public void Visi(Car car)
    {
        Debug.Log("Car is off.");
    }
    
    
}
