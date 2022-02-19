using UnityEngine;
public class DebugUIManagerWithZenject : IUIManagerWithZenject
{
    public void UpdateEnergyText(string text)
    {
        Debug.Log(text);
    }

    public void UpdateHealthText(string text)
    {
        Debug.Log(text);
    }

    public void UpdatePointText(string text)
    {
        Debug.Log(text);
    }
}
