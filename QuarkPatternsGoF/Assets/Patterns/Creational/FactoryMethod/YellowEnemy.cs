using UnityEngine;

public class YellowEnemy : Enemy
{
    public override string Name => "YellowEnemy";

    public override void Process()
    {
        Debug.Log($"Soy: {Name}");
    }
}

