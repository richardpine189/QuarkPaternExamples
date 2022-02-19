using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroBuilder
{
    IHeroWeapon _heroWeapon;
    IHeroClass _heroClass;
    IHeroRace _heroRace;
    Hero _hero;

    public HeroBuilder HeroWithRace(IHeroRace heroRace)
    {
        _heroRace = heroRace;
        return this;
    }

    public HeroBuilder HeroWithClass(IHeroClass heroClass)
    {
        _heroClass = heroClass;
        return this;
    }

    public HeroBuilder HeroWithWeapon(IHeroWeapon heroWeapon)
    {
        _heroWeapon = heroWeapon;
        return this;
    }

    public Hero Build(Hero hero)
    {
        Debug.Log(_heroClass.ToString());
        Debug.Log(_heroRace.ToString());
        Debug.Log(_heroWeapon.ToString());
        //Here we can instantiate the parts if we need it.
        hero.HeroClass = _heroClass as HeroClass;
        hero.HeroRace = _heroRace as HeroRace;
        hero.HeroWeapon = _heroWeapon as HeroWeapon;
        return hero;
    }
}
