using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float Tiempos;
    public Text Cronometro;
    private int contador ;

    // Start is called before the first frame update
    void Start()
    {

        Cronometro.text = Tiempos.ToString();

    }   


    // Update is called once per frame
    void Update()
    {
        Tiempos -= Time.deltaTime;
        Cronometro.text = Mathf.Round(Tiempos).ToString();
        if (Tiempos < 0)
        {
            SceneManager.LoadScene("GameOver");
            //UnityEditor.EditorApplication.isPlaying = false;
            //Application.Quit();
        }


    }
}
