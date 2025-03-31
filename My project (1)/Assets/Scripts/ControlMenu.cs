using UnityEngine;
using UnityEngine.SceneManagement;
public class ControlMenu : MonoBehaviour
{

    public void IrAJugar()
    {
        SceneManager.LoadScene("Aniimaaciones");
    }

     public void IrAMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;    
    }
}
