using TMPro;
using UnityEngine;

public class HealthView : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _health;
    private IHero hero;

    public void Configure(IHero hero)
    {
        hero.OnHealthUpdated += Updated;
    }

    public void OnDestroy()
    {
        hero.OnHealthUpdated -= Updated;
    }

    private void Updated(int health)
    {
        _health.text = $"Hero's Life: {health}";
    }
}
