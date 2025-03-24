using UnityEngine;

public class ManagerPausa : MonoBehaviour
{
    public GameObject pausa;
    public bool isPaused;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            PuaseGame();
        }
        
    }

    public void PuaseGame(){
        if(!isPaused){
            pausa.SetActive(true);
            Time.timeScale = 0;
            isPaused = !isPaused;
        }else{
            pausa.SetActive(false);
            Time.timeScale = 1;
            isPaused = !isPaused;
        }
    }
}
