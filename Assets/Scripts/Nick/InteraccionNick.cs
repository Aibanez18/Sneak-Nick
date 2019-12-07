using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionNick : MonoBehaviour
{
	bool interactuo = false;

	public GameObject mensajeInteraccion;
    public Puerta scriptP;
    public Computador scriptC;

	void OnTriggerEnter2D(Collider2D otro)
	{
        Reconocer(otro);
        mensajeInteraccion.SetActive(true);
		interactuo = false;
	}

	void OnTriggerStay2D(Collider2D otro)
	{
        if (Input.GetKey(KeyCode.E))
        {
            Interactuar(otro);
        }
    }

    private void Interactuar(Collider2D otro)
    {
        if (!interactuo)
        {
            if (otro.CompareTag("Computador"))
            {
                scriptC.apagarCamaras();
                interactuo = true;
                mensajeInteraccion.SetActive(false);
            }
            else if (otro.CompareTag("Puerta"))
            {
                scriptP.cambiarEstado();
                interactuo = true;
            }
        }
    }

    private void Reconocer(Collider2D otro)
    {
        if (otro.CompareTag("Puerta"))
        {
            scriptP = otro.GetComponent<Puerta>();
        }
        else if (otro.CompareTag("Computador"))
        {
            scriptC = otro.GetComponent<Computador>();
        }
    }

    void OnTriggerExit2D()
	{
		mensajeInteraccion.SetActive(false);
		interactuo = false;
	}
}
