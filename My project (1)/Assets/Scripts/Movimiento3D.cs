using UnityEngine;

public class Movimiento3D : MonoBehaviour
{
    Animator anim;
    CharacterController controlador;
    public Vector3 direccion;
    public float gravedad = 9.81f;
    public float rotacion;
    public float velRotacion = 5f;
    public float salto = 50f;
    public float velocidad = 5f;
    public float vertical;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){

        controlador = gameObject.GetComponent<CharacterController>();
        anim = gameObject.GetComponent<Animator>();    
        
    }

    // Update is called once per frame
    void Update(){

        if (controlador.isGrounded){
            anim.SetTrigger("suelo");
            vertical = Input.GetAxisRaw("Vertical");
            direccion = gameObject.transform.TransformDirection(new Vector3(0,0,Input.GetAxis("Vertical") * velocidad));
            rotacion = Input.GetAxis("Horizontal")* velRotacion;

            anim.SetFloat("move", vertical);

            if(vertical == 0){
                anim.SetBool("idle", true);

            }else {
                anim.SetBool("idle",false);
            }

            if(Input.GetKeyDown(KeyCode.Space)){
                direccion.y += salto * Time.deltaTime;
                this.controlador.transform.Rotate(Vector3.zero);
                anim.SetTrigger("Jump");

            }

            
        } else {
            anim.ResetTrigger("suelo");
        }

            direccion -= new Vector3(0,gravedad*Time.deltaTime,0);
            controlador.transform.Rotate(new Vector3(0,rotacion,0));
            controlador.Move(direccion*Time.deltaTime);
        
    }


}
