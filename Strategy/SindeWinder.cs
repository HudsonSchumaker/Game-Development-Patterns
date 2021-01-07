// Hudson Schumaker

public class SindeWinder : Missile
{
    void Awake()
    {
        this.SeekBehaviour = new Heatseeker();
    }
}
