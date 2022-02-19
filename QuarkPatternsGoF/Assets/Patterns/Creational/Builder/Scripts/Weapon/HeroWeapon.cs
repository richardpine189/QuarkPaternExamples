using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Patterns/Builder/NewHeroWeapon")]
public class HeroWeapon : ScriptableObject, IHeroWeapon
{
    [SerializeField] string _weaponName;
    [SerializeField] int _damage;
}
