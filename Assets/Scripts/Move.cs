using UnityEngine;

public class Move : MonoBehaviour
{
    public float velocidad;
    public float movVertical, movHorizontal;
    public Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

        movHorizontal = Input.GetAxis("Horizontal");
        movVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movHorizontal,0,movVertical);

        rb.AddForce(movimiento*velocidad);
        
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Finish")
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Finish")
        {
            Destroy(other.gameObject);
        }
    }


}

