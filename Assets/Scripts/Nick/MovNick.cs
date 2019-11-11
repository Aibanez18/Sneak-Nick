using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovNick : MonoBehaviour
{
    Vector3 direccion;
    public float velocidadInicial = 5f;
    [Range (0.1f,0.9f)]
    public float multSigilo = 0.5f;
    [Range (1.1f,2f)]
    public float multVeloz = 0.5f;
    float velocidad;
    
    void Update()
    {
        direccion.x = Input.GetAxis("Horizontal");
        direccion.y = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            velocidad = velocidadInicial * multVeloz;
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            velocidad = velocidadInicial * multSigilo;
        }
        else
        {
            velocidad = velocidadInicial;
        }
        
        
    }

    void FixedUpdate()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);
    }

    void detectarInput()
    {
        direccion.x = Input.GetAxis("Horizontal");
        direccion.y = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.LeftControl))
        {
            velocidad = velocidadInicial * 0.7f;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            velocidad = velocidadInicial * 1.3f;
        }
        else
        {
            velocidad = velocidadInicial;
        }
    }
}
