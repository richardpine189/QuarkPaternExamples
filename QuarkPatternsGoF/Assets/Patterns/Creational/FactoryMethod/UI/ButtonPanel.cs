using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPanel : MonoBehaviour
{
    [SerializeField] EnemyButton enemyButtonPrefab;
    [SerializeField] EnemyFactory enemyFactory;
    private void OnEnable()
    {
        foreach(string name in enemyFactory.GetEnemyName())
        {
            var button = Instantiate(enemyButtonPrefab);
            button.gameObject.name = $"{name} Button";
            button.gameObject.GetComponentInChildren<Text>().text = $"Create {name}"; // fuera de clase
            button.transform.SetParent(transform); 
        }
    }
}
