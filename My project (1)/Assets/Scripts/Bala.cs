using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad;
    public float timeLife = 2.5f;
    public Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (rb == null){
            rb = GetComponent<Rigidbody>();
        }

        rb.linearVelocity = transform.forward * velocidad;
        Destroy(gameObject, timeLife);
    }
}