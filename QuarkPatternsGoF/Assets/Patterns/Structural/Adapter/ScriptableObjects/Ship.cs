using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewShipForAdapter", menuName = "Patterns/AdapterExample/Ship")]
public class Ship : ScriptableObject
{
    [SerializeField]
    private string shipName;
    [SerializeField]
    private float speed;
    [SerializeField]
    private Vector3 position;

    public string ShipName { set { shipName = value; } get { return shipName; } }
    public float Speed { set { speed = value; } get { return speed; } }
    public Vector3 Position { set { position = value; } get { return position; } }
}
