using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager
{
    private TextMeshProUGUI _lifeText;
    private TextMeshProUGUI _energyText;

    private static UIManager _uiManager;
    private UIManager() {
        _lifeText = GameObject.Find("LifeText").GetComponent<TextMeshProUGUI>();
        _energyText = GameObject.Find("EnergyText").GetComponent<TextMeshProUGUI>();
    }
    public static UIManager UiManager
    {
        get
        {
            if(_uiManager == null)
            {
                _uiManager = new UIManager();
            }
            return _uiManager;
        }
    }

    public void UpdateLifeInUI(int value)
    {
        _lifeText.text = $"Life: {value}";
    }

    public void UpdateEnergyInUI(int value)
    {
        _energyText.text = $"Energy: {value}";
    }


}
