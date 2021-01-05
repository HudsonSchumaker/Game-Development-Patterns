// Hudson Schumaker

public class EnemySpawner
{
    public Enemy SpawnEnemy(Enemy prototype)
    {
        return (Enemy) prototype.Copy();
    }
}
