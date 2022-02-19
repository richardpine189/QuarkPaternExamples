using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] HeroAttribute _life;
    [SerializeField] HeroAttribute _energy;

    public HeroAttribute Life { get => _life; private set => _life = value; }
    public HeroAttribute Energy { get => _energy; private set => _energy = value; }

    private void Start()
    {
        UIManager.UiManager.UpdateEnergyInUI(Energy.Value);
        UIManager.UiManager.UpdateLifeInUI(Life.Value);
    }

    public void IncreaseLife()
    {
        Life.Value++;
    }
    public void DecreaseLife()
    {
        Life.Value--;
    }
    public void IncreaseEnergy()
    {
        Energy.Value++;
    }
    public void DecreaseEnergy()
    {
        Energy.Value--;
    }
}
