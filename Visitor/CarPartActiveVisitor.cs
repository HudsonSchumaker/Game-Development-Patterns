using UnityEngine;

// Hudson Schumaker

public class CarPartActiveVisitor : ICarPartVisitor
{
    public void Visit(Car car)
    {
        Debug.Log("Car starting...");
    }
}
