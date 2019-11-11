using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class TargetEnemigo : MonoBehaviour
{
	CampoDeVisionEnemigo cdv;
	AIPath ai;

	public List<Transform> puntos = new List<Transform>();
	int contPuntos = 1;
	Transform objetivo;

    void Start()
    {
		cdv = GetComponent<CampoDeVisionEnemigo>();
		ai = GetComponent<AIPath>();
		objetivo = puntos[contPuntos];
		ai.destination = objetivo.position;
    }

    void Update()
    {
		if (Vector3.Distance(transform.position, objetivo.position)<1f)
		{
			CambiarObjetivo();
		}
    }

	void CambiarObjetivo()
	{
		if (contPuntos<puntos.Count-1)
		{
			contPuntos += 1;
		}
		else
		{
			contPuntos = 0;
		}
		objetivo = puntos[contPuntos];
		ai.destination = objetivo.position;
	}
}
