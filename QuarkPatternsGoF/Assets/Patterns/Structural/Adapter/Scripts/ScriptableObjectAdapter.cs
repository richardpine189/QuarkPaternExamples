using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjectAdapter : MonoBehaviour, IPersistenceAdapter
{
    [SerializeField]
    private List<Ship> ships;

    private Dictionary<string, Ship> playersDictionary = new Dictionary<string, Ship>();
    private void Awake()
    {
        foreach(Ship p in ships)
        {
            playersDictionary.Add(p.ShipName, p);
            
        }
    }
    public void Get(string ShipName, out float speed, out Vector3 position)
    {
        Ship tempPlayer;
        playersDictionary.TryGetValue(ShipName, out tempPlayer);
        speed = tempPlayer.Speed;
        position = tempPlayer.Position;
    }

    public void Set(string shipName, float speed, Vector3 position)
    {
        foreach(Ship p in ships)
        {            
            if(shipName == p.ShipName)
            {
                p.Speed = speed;
                p.Position = position;
            }
        }
    }
}
