using System;
using System.Collections.Generic;
using UnityEngine;
public class EnemyFactory : MonoBehaviour
{
    [SerializeField] EnemyFactoryConfig enemyFactoryConfig;

    public Enemy GetEnemyById(string enemyName)
    {
        var enemysByName = enemyFactoryConfig.InitializeFactory();
        if (enemysByName.ContainsKey(enemyName))
        {
            Type type = enemysByName[enemyName];
            var enemy = Activator.CreateInstance(type) as Enemy;
            return enemy;
        }
        return null;
    }
    public IEnumerable<string> GetEnemyName()
    {
        var enemysByName = enemyFactoryConfig.InitializeFactory();
        return enemysByName.Keys;
    }
}
