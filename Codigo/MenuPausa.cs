using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MenuPausa : MonoBehaviour
{
    [SerializeField] GameObject botonPausa;
    [SerializeField] GameObject menuPausa;
    [SerializeField] VideoPlayer video;

    public void PlayVideo(){
        video.Play();
    }

    public void PauseVideo(){
        video.Pause();
    }

    private bool juegoPausado = false;

    private void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(juegoPausado){
                Reanudar();
            } else {
                Pausa();
            }
        }
    }
    public void Pausa(){
        juegoPausado = true;
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    public void Reanudar(){
        juegoPausado = false;
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }

    public void Salir(){
        Application.Quit();
    }

    public void MenudeSeleccion(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("Seleccion");
    }

}
