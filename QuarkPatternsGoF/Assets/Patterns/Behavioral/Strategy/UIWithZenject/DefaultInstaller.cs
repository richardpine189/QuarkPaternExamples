using UnityEngine;
using Zenject;


public class DefaultInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IUIManagerWithZenject>().To<UIManagerWithZenject>().AsSingle().NonLazy();
    }
}