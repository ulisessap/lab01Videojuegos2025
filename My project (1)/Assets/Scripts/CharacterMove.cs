using UnityEngine;

public class CharacterMove : MonoBehaviour
{

    public float horizontal;
    public float vertical;
    public float velocidad, velocidadOriginal;
    //public float gravedad;
    public Vector3 direccion;
    public CharacterController cc;

    private Renderer rend;
    private Color colorOriginal;

    private Rigidbody rb;
    public float salto;
   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cc = this.gameObject.GetComponent<CharacterController>();
        rb = this.gameObject.GetComponent<Rigidbody>();
        velocidadOriginal = velocidad;

        rend = GetComponent<Renderer>();

        if (rend != null)
        {
            rend.material = new Material(rend.material);
            colorOriginal = rend.material.color;    
        }
        
    }

    // Update is called once per frame
    void Update()
    {   
        //Diferencia entre GetAxis y Raw
        //Raw -1 0 1
        //Solo GetAxis los valores estan en ese intervalo y primero se mueve mas despacio y luego alcanza la velocidad
        direccion = Vector3.zero;
        //direccion.y -= gravedad;
        direccion.x = Input.GetAxisRaw("Horizontal") * velocidad;
        direccion.z = Input.GetAxisRaw("Vertical") * velocidad;

        this.transform.position += direccion*Time.deltaTime;

        //cc.Move(direccion*Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space");
            direccion.y += salto;
            rb.AddForce(direccion*salto, ForceMode.Impulse);
        }
        
    }

    public void setVelocidad(float velocidad){
        this.velocidad = velocidad;
    }

    public void resetVelocidad(){
        this.velocidad = velocidadOriginal;
    }

    public void changeColor(Color newColor)
    {
        if (rend != null)
        {
            rend.material = new Material(rend.material); 
            rend.material.SetColor("_BaseColor", newColor); 
        }
    }   

    public void resetColor(){

         if (rend != null)
        {
            rend.material.SetColor("_BaseColor", colorOriginal);
        }
    }
}
