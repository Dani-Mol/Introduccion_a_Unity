using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(superVelocidad(other.gameObject));
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            this.gameObject.GetComponent<SphereCollider>().enabled = false;
            Destroy(this.gameObject, 4.0f);


        }
    }

    IEnumerator superVelocidad(GameObject player)
    {
        player.GetComponent<CharacterMovement>().setVelocidad(10.0f);
        yield return new WaitForSeconds(3.0f);
        player.GetComponent<CharacterMovement>().resetVelocidad();
    }
}
