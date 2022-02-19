using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] private HeroClass _heroClass;
    [SerializeField] private HeroWeapon _heroWeapon;
    [SerializeField] private HeroRace _heroRace;

    public HeroClass HeroClass { get => _heroClass; set => _heroClass = value; }
    public HeroWeapon HeroWeapon { get => _heroWeapon; set => _heroWeapon = value; }
    public HeroRace HeroRace { get => _heroRace; set => _heroRace = value; }
}
