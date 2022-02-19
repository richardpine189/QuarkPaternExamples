using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerConsumer : MonoBehaviour
{
    [SerializeField] HeroClass[] _heroClasses;
    [SerializeField] HeroRace[] _heroRaces;
    [SerializeField] HeroWeapon[] _heroWeapons;
    [SerializeField] Hero _hero;

    HeroBuilder _heroBuilder;
    
    public void CreateRandomHero()
    {
        int classIndex= Random.Range(0,_heroClasses.Length);
        int raceIndex = Random.Range(0, _heroRaces.Length);
        int weaponIndex = Random.Range(0, _heroWeapons.Length);

        _heroBuilder = new HeroBuilder();

        _heroBuilder.HeroWithClass(_heroClasses[classIndex]);
        _heroBuilder.HeroWithRace(_heroRaces[raceIndex]);
        _heroBuilder.HeroWithWeapon(_heroWeapons[weaponIndex]);
        _heroBuilder.Build(_hero);
        

        
    }
    
}
