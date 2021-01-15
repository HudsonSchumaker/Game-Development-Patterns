using UnityEngine;

// Hudson Schumaker
public class Car : ICarPart
{
    private ICarPart [] carParts;
    
    public Car() 
    {
        carParts = {};
    }
    
    public void Accept(ICarPartVisitor visitor)
    {}
    
}
