using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterFactory
{
    private readonly HeroesFactory _heroesFactory;

    public MasterFactory(HeroesFactory heroesFactory)
    {
        _heroesFactory = heroesFactory;
    }

    public void Create(string idHero)
    {
        
        _heroesFactory.CreateHero(idHero);
    }
}
