using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class UICall : MonoBehaviour
{
    [Inject] IUIManagerWithZenject uiManager;
    // Start is called before the first frame update
    void Start()
    {
        uiManager.UpdateEnergyText("This is a new energy deploy text");
        uiManager.UpdateHealthText("This is a new health deploy text");
        uiManager.UpdatePointText("This is a new point deploy text");
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
