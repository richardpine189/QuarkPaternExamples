using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroesFactory
{
    private readonly HeroesFactoryConfig _heroesFactoryConfig;

    public HeroesFactory(HeroesFactoryConfig heroFactoryConfig)
    {
        _heroesFactoryConfig = heroFactoryConfig;
    }

    public void CreateHero(string id)
    {
        Debug.Log("Dentro de la HeroesFactory recibo " + id);
        var hero = _heroesFactoryConfig.GetHero(id);
        GameObject newGameObj = new GameObject();
        newGameObj.name = $"New {id}";
        newGameObj.AddComponent(hero);
        newGameObj.GetComponent<Hero>().Id = id;
        
    }
}
