using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computador : MonoBehaviour
{
    int uso = 1;

    public void apagarCamaras()
    {
        if (uso == 1)
        {
            Camara[] camaras = FindObjectsOfType<Camara>();
            if (camaras.Length >= 1)
            {
                foreach (Camara camara in camaras)
                {
                    Camara vision = camara.GetComponent<Camara>();
                    vision.enabled = false;
                }
                uso -= 1;
            }
        }
    }
}
