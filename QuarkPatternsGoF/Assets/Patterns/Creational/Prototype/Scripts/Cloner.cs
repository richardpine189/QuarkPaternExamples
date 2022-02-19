using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Cloner : MonoBehaviour
{
    [SerializeField] Hechizo _fueguito;
    [SerializeField] Hechizo _newHechizo;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            _newHechizo = ScriptableObject.CreateInstance<Hechizo>();

            _newHechizo = _fueguito.DeepClone() as Hechizo;

            AssetDatabase.CreateAsset(_newHechizo, "Assets/Patterns/Creational/Prototype/MisHechizos/NewFueguito.asset");

            Debug.Log($"Se ha clonado el Hechizo llamado: {_newHechizo.name}");
        }


    }
}
