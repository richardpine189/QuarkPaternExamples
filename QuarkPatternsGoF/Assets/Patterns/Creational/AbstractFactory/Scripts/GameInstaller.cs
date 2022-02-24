using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstaller : MonoBehaviour
{
    [SerializeField] HeroesFactoryConfig _heroesFactoryConfig;
    // Start is called before the first frame update
    void Start()
    {
        _heroesFactoryConfig.InitializeFactory();
        
        var heroesFactory = new HeroesFactory(_heroesFactoryConfig);

        var consumerGameObject = new GameObject();

        var consumer = consumerGameObject.AddComponent<Consummer>();

        consumer.InitialConfiguration(new MasterFactory(heroesFactory));
    }

}
