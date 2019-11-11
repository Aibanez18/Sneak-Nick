using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionNick : MonoBehaviour
{
	bool interactuo = false;

	public GameObject mensajeInteraccion;
	public Puerta scriptPuerta;

	void OnTriggerEnter2D(Collider2D otro)
	{
		if (otro.CompareTag("Puerta"))
		{
			scriptPuerta = otro.GetComponent<Puerta>();
		}
		mensajeInteraccion.SetActive(true);
		interactuo = false;
	}

	void OnTriggerStay2D(Collider2D otro)
	{
		if (otro.CompareTag("Puerta"))
		{
			if (Input.GetKey(KeyCode.E))
			{
				if (!interactuo)
				{
					scriptPuerta.cambiarEstado();
					interactuo = true;
				}

			}
		}
	}

	void OnTriggerExit2D()
	{
		mensajeInteraccion.SetActive(false);
		interactuo = false;
	}
}
