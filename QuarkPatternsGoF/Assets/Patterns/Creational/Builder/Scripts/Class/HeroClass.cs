using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Patterns/Builder/NewHeroClass")]
public class HeroClass : ScriptableObject, IHeroClass
{
    [SerializeField] string _className;
    [SerializeField] string _description;
}
