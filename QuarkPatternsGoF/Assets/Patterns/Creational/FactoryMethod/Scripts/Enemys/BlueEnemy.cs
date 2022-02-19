using UnityEngine;

public class BlueEnemy : Enemy
{
    public override string Name => "BlueEnemy";

    public override void Process()
    {
        Debug.Log($"Soy: {Name}");
    }
}

