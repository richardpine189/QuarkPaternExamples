using UnityEngine;

public class Installer : MonoBehaviour
{
    [SerializeField] HealthView _healthView;

    private Hero _hero;

    public void Awake()
    {
        _hero = new Hero();
        _healthView.Configure(_hero);
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            _hero.DoDamage(10);
        }
    }
}
