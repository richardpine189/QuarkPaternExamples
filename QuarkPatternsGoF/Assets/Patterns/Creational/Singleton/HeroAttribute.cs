using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Patterns/SingletonExample/Attribute", fileName = "New Attribute")]
public class HeroAttribute : ScriptableObject
{
    [SerializeField] private int value;

    public int Value { get => value; set => this.value = value; }
}
    
