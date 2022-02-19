using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{

    IPersistenceAdapter persistanceAdapter;
    [SerializeField]
    private float speed;
    private Vector3 initialPosition;
    [SerializeField]
    private string shipName;
    public bool Enable { set; get; }

    private void Awake()
    {
        persistanceAdapter = GameObject.FindObjectOfType<ScriptableObjectAdapter>();
        persistanceAdapter.Get(shipName, out speed, out initialPosition);
        transform.position = initialPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Enable)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            if (horizontal != 0)
            {
                transform.Translate(Vector3.right * horizontal * Time.deltaTime * speed);
            }
            if (vertical != 0)
            {
                transform.Translate(Vector3.up * vertical * Time.deltaTime * speed);
            }
            
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            persistanceAdapter.Set(shipName, speed, transform.position);
        }
    }
}
