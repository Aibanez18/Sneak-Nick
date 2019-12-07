using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mens : MonoBehaviour
{
    private int contador;
    public Text Celulars;
    public List<string> Mensajes = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        Mensajes.Add("Acercate a las murallas,\n pueden haber puertas pero\n cuidado con los enemigos");
        Mensajes.Add("Hay items en las habitaciones\n pueden ser útiles");
        Mensajes.Add("Si te encuentran \n van a estar más alerta");
        Mensajes.Add("Hay camaras escondidas");
        Mensajes.Add("");
        contador = Mensajes.Count;
        StartCoroutine(Test());
    }

    IEnumerator Test()
    {
    for (int i = 0; i < contador; i++)
    {
        yield return new WaitForSeconds(10);
        Celulars.text = Mensajes[i];
        yield return new WaitForSeconds(3);
        Celulars.text = "";
    }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
