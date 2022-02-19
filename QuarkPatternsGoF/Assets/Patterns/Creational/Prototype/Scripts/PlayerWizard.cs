using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWizard : MonoBehaviour
{
    /* Planteo propuesto rescatando la simplicidad de la aplicación del patrón.
     * El array de hechizos deberia reemplazarse para una mejor eficiencia con:
     * 1) Una lista y trabajarla con LinQ
     * 2) Con un diccionario donde la key sea el nombre del hechizo y el value la instancia en si.
     */

    [SerializeField] Hechizo current;
    [SerializeField] Hechizo[] avalibles;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            current = avalibles[0];
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            current = avalibles[1];
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            current = avalibles[2];
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            current.DoAction();
        }
    }
}
