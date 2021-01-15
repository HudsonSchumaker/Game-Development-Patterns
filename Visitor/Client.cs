using UnityEngine;

// Hudson Schumaker
public class Client : MonoBehavior
{
    void Update()
    {
        // Start car
        if (Input.GetKeyDown(KeyCode.C))
        {
            ICarPart car = new Car();
            car.Accept(new CarPartActivateVisitor());
        }
        
        // Turn off car
        if (Input.GetKeyDown(KeyCode.S))
        {
            ICarPart car = new Car();
            car.Accept(new CarPartShutdownVisitor());
        }
    }
}
