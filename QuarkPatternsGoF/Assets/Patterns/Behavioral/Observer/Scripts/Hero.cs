using System;

public class Hero : IHero
{
    public event Action<int> OnHealthUpdated;
    private int Health { set; get; }

    public Hero()
    {
        Health = 100;
        Notify();
    }

    public void Notify()
    {
        OnHealthUpdated?.Invoke(Health);
    }

    public void DoDamage(int damage)
    {
        Health -= damage;
        Notify();
    }
}
