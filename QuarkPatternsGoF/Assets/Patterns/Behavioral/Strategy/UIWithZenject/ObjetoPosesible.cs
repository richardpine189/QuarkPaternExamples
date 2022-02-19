using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewObjectToPossess", menuName = "ObjetosPosesibles")]
public class ObjetoPosesible : ScriptableObject
{
    [SerializeField] Vector3 initPosition;
    [SerializeField] string currentScene;
    [SerializeField] string objectName;
}
