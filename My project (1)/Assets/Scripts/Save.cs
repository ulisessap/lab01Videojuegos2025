using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering;
public class Save : MonoBehaviour
{
    public TMP_Text balas;

    private void Awake()
    {
        LoadData();
    }

    //En los prefs solo deberiamos de guardar las configuraciones
    public void SaveData(){
        //Si la llave no exste, la crea
        PlayerPrefs.SetInt("balas",int.Parse(balas.text));

    }

    public int LoadData(){
        int puntos = PlayerPrefs.GetInt("balas");
        balas.text = puntos.ToString();
        return puntos;
    }

    public void ResetData(){
        PlayerPrefs.DeleteAll();
        //DeleteKey para borrar llave en especifico
    }
}
