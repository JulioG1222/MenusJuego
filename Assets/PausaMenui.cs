using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PausaMenui : MonoBehaviour
{
    public Image imagen; // Referencia a la imagen que quieres activar/desactivar


    public void Pausa()
    {
        imagen.gameObject.SetActive(!imagen.gameObject.activeSelf);
        Time.timeScale = 0;
    }

    public void Reanudar()
    {
        imagen.gameObject.SetActive(!imagen.gameObject.activeSelf);
        Time.timeScale = 1;
    }

    public void Salir()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
