using UnityEngine;

public class fixedupdate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(0,0,0.1f*Time.deltaTime*5);
    }
}
