using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPersistenceAdapter
{
    void Set(string shipName, float speed, Vector3 position);
    void Get(string shipName, out float speed, out Vector3 position);
}
