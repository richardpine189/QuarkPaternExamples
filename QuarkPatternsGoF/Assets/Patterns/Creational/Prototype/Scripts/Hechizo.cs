using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( menuName = "Hechizos/HechizoPequeño")]
public class Hechizo : ScriptableObject, IClonable, IDeepClonable
{
    [SerializeField] int daño;
    [SerializeField] int alcance;
    [SerializeField] string textoADesplegar;
    
    public void DoAction()
    {
        Debug.Log(textoADesplegar);
    }

    public object Clone()
    {
        var tempObject = this.MemberwiseClone();
        return tempObject;
    }

    public object DeepClone()
    {
        var newClone = this.MemberwiseClone() as Hechizo;
        newClone.textoADesplegar = String.Copy(this.textoADesplegar);
        return newClone;
    }
}
