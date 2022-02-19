using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenEnemy : Enemy
{
    public override string Name => "GreenEnemy";

    public override void Process()
    {
        Debug.Log($"Soy: {Name}");
    }
}

