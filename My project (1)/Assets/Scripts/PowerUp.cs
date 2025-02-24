using System.Collections;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   private void OnTriggerEnter(Collider other){

    if(other.gameObject.tag == "Player")
    {
        StartCoroutine(superVel(other.gameObject));
        Destroy(this.gameObject, 3.0f);
    }
   }

   IEnumerator superVel(GameObject player){
        //this.gameObject.GetComponent<SphereCollider>().enabled = false;
        this.gameObject.GetComponent<SphereCollider>().enabled = false;
        player.GetComponent<CharacterMove>().setVelocidad(10.0f);
        yield return new WaitForSeconds(3.0f);
        player.GetComponent<CharacterMove>().resetVelocidad();

    Destroy(this.gameObject);
   }
}
