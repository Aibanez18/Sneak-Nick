using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private Inventario inventario;
    public int i;

    public void DropItem()
    {
        foreach(Transform child in transform)
        {
            child.GetComponent<Aparecer>().ApareceDropItem();
            GameObject.Destroy(child.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount <= 0)
        {
            inventario.isFull[i] = false;
        }
    }
}
