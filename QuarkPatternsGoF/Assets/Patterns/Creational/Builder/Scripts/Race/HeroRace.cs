using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Patterns/Builder/NewHeroRace")]
public class HeroRace : ScriptableObject, IHeroRace
{
    [SerializeField] string _raceName;
    [SerializeField] string _description;
}
