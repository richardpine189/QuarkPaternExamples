using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    UIManager uIManager;
    private Hero _hero;
    // Start is called before the first frame update
    void Start()
    {
        uIManager  = UIManager.UiManager;
        _hero = GameObject.Find("Hero").GetComponent<Hero>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _hero.IncreaseLife();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _hero.DecreaseLife();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _hero.IncreaseEnergy();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _hero.DecreaseEnergy();
        }

        uIManager.UpdateEnergyInUI(_hero.Energy.Value);
        uIManager.UpdateLifeInUI(_hero.Life.Value);

    }
}
