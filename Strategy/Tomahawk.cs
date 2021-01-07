// Hudson Schumaker

public class Tomahawk : Missile
{
    void Awake()
    {
        this.SeekBehaviour = new Gps();
    }
}
