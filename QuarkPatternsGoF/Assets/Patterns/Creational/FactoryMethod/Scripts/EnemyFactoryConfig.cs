using UnityEngine;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System;

[CreateAssetMenu(menuName = "Patterns/Factorys/EnemyConfiguration")]
public class EnemyFactoryConfig : ScriptableObject
{
    private Dictionary<string, Type> enemysByName;

    private bool isInitialize => enemysByName != null;
    public Dictionary<string,Type> InitializeFactory()
    {
        if (isInitialize) return enemysByName;

        var enemyTypes = Assembly.GetAssembly(typeof(Enemy)).GetTypes()
            .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Enemy)));

        enemysByName = new Dictionary<string, Type>();

        foreach (var type in enemyTypes)
        {
            var tempEffect = Activator.CreateInstance(type) as Enemy;
            enemysByName.Add(tempEffect.Name, type);
        }
        return enemysByName;

    }
    
}
