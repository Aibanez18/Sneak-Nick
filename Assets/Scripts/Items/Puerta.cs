using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
	bool abierto = false;
	public float velocidadRotacion = 100f;
	Vector3 posicionPivote;
	float rotacionInicial;

	void Start()
	{
		rotacionInicial = transform.eulerAngles.z;
		posicionPivote = transform.position + transform.right*transform.localScale.x/2 + transform.up*transform.localScale.y/2;
	}

	public void cambiarEstado()
	{
		abierto = !abierto;
	}

	void FixedUpdate()
	{
		if (abierto)
		{
			if (transform.eulerAngles.z < rotacionInicial + 90)
			{
				transform.RotateAround(posicionPivote, Vector3.forward, Time.deltaTime*velocidadRotacion);
				if (transform.eulerAngles.z >= rotacionInicial + 90)
				{
					AstarPath.active.Scan();
				}
			}
		}
		else
		{
			if (transform.eulerAngles.z > rotacionInicial + 3 )
			{
				transform.RotateAround(posicionPivote, -Vector3.forward, Time.deltaTime*velocidadRotacion);
				if (transform.eulerAngles.z >= rotacionInicial + 3 )
				{
					AstarPath.active.Scan();
				}
			}
		}
	}
}
