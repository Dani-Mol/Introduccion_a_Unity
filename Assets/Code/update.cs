using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class update: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0,0,0.1f * Time.deltaTime * 5);
        // this.transform.Translate(0,0,0.01f); Suma de vectores (mueve de un objeto a otro) (objeto que esta asociado al objeto)
    }
}


//Llama menos a fixedupdate (comportamientos deberia ir en fixed)