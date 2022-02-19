using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "AlgunLado", menuName = "Installers/AlgunLado")]
public class AlgunLado : ScriptableObjectInstaller<AlgunLado>
{
    public override void InstallBindings()
    {

        Container.Bind<IUIManagerWithZenject>().To<UIManagerWithZenject>().AsSingle().NonLazy();
    }
}
