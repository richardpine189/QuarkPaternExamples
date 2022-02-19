using UnityEngine;

public class RedEnemy : Enemy
{
    public override string Name => "RedEnemy";

    public override void Process()
    {
        Debug.Log($"Soy: {Name}");
    }
}

