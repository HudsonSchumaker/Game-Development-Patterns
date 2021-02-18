// Hudson Schumaker
public class Torpedo : Missile
{
    void Awake()
    {
        this.SeekBehaviour = new Sonar();
    }
}
