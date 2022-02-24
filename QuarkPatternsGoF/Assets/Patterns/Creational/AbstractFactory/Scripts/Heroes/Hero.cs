using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Hero : MonoBehaviour
{
    [SerializeField] protected string id;

    public string Id { get => id; set => id = value; }
}
