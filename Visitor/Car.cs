using UnityEngine;

// Hudson Schumaker
public class Car : ICarPart
{
    private ICarPart [] carParts;
    
    public Car() 
    {
        carParts = new ICarPart[] { new Turbo(), new Gun(), new Battery() };
    }
    
    public void Accept(ICarPartVisitor visitor)
    {
        for(int i = 0; i < carParts.Lengh; i++)
        {
            carParts[i].Accept(visitor);
        }
        visitor.Visit(this);
    }
}
