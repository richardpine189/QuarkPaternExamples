using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System.Linq;

[CreateAssetMenu(menuName = "Patterns/AbstractFactory/New Config File")]
public class HeroesFactoryConfig : ScriptableObject
{
    private Dictionary<string, Type> heroById;

    private bool isInitialize => heroById != null;

    public Dictionary<string, Type> InitializeFactory()
    {
        if (isInitialize) return heroById;
        var heroTypes = Assembly.GetAssembly(typeof(Hero)).GetTypes()
            .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Hero)));

        heroById = new Dictionary<string, Type>();
        

        foreach (var type in heroTypes)
        {
            //var tempEffect = Activator.CreateInstance(type) as Hero;
            heroById.Add(type.ToString(), type);
        }

        return heroById;

    }

    public Type GetHero(string id)
    {
        Debug.Log("Dentro de la HeroesFactoryConfig recibo " + id);

        Debug.Log(heroById.ToString());

        var heroType = heroById[id];

       // var hero = Activator.CreateInstance(heroType) as Hero;

        return heroType;
    }

}
