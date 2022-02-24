using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consummer : MonoBehaviour
{
    private MasterFactory _masterFactory;

    public void InitialConfiguration(MasterFactory masterFactory)
    {
        _masterFactory = masterFactory;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            _masterFactory.Create("Paladin");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _masterFactory.Create("Wizard");
        }
    }
}
