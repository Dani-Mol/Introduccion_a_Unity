using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lateUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.Translate(0,0,0.1f * Time.deltaTime * 5);
    }
}
