using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShip : MonoBehaviour
{
    [SerializeField] ShipMovement[] shipScripts;
    // Start is called before the first frame update
    void Start()
    {
        ShutDownScript();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Alpha1))
        {
            ShutDownScript();
            shipScripts[0].Enable = true;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            ShutDownScript();
            shipScripts[1].Enable = true;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            ShutDownScript();
            shipScripts[2].Enable = true;
        }
    }

    void ShutDownScript()
    {
        foreach(ShipMovement s in shipScripts)
        {
            s.Enable = false;
        }
    }
}
