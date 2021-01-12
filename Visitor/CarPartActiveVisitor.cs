using UnityEngine;

// Hudson Schumaker

public class CarPartActiveVisitor : ICarPartVisitor
{
    public void Visit(Car car)
    {
        Debug.Log("Car starting...");
    }
    
    public void Visit(Battery battery)
    {
        Debug.Log("Battery is charged.");
    }
    
    public void Visit(Turbo turbo)
    {
        Debug.Log("Turbo is charging...");
    }
    
    public void Visit(Gun gun)
    {
        Debug.Log("Gun is loaded and ready.");
    }
}
