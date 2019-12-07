using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    private int ProxEscena;
    //[SerializeField]
    //private string NivelNuevo;
    // Start is called before the first frame update
    void Start()
    {
        ProxEscena = SceneManager.GetActiveScene().buildIndex + 1;
    }
    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Player"))
        {
            SceneManager.LoadScene(ProxEscena);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
