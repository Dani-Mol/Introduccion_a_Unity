using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharacterMovement : MonoBehaviour
{   
    public float horizontal;
    public float vertical;
    public float velocidad, velocidadOriginal;
    public float gravedad;
    public Vector3 direccion;
    public CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        this.cc = this.gameObject.GetComponent<CharacterController>();
        velocidadOriginal = velocidad = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        direccion = Vector3.zero;
        direccion.y -= gravedad;
        direccion.x = Input.GetAxisRaw("Horizontal") * velocidad; 
        direccion.z = Input.GetAxisRaw("Vertical") * velocidad; 
        
        this.transform.LookAt(this.transform.position + new Vector3(direccion.x, 0, direccion.z));

        this.cc.Move(direccion * Time.deltaTime);
   
    }

public void setVelocidad(float velocidad)
{
    this.velocidad = velocidad;
}

public void resetVelocidad()
{
    this.velocidad = this.velocidadOriginal;
}

}
