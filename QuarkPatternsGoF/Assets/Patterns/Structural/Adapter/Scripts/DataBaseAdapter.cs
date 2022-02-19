using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBaseAdapter : IPersistenceAdapter
{
    public void Get(string ShipName, out float speed, out Vector3 position)
    {
        throw new System.NotImplementedException();
    }

    public void Set(string shipName, float speed, Vector3 position)
    {
        throw new System.NotImplementedException();
    }
}
