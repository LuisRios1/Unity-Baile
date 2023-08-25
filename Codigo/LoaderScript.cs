using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaJuegoDMC()
    {
    //Carga nivel
       SceneManager.LoadScene("Nivel 1");
    }

        public void EscenaJuegoVaq()
    {
    //Carga nivel
       SceneManager.LoadScene("Nivel 2");
    }

        public void EscenaJuegoGor()
    {
    //Carga nivel
       SceneManager.LoadScene("Nivel 3");
    }

        public void Menu()
    {
    //Carga nivel
       SceneManager.LoadScene("MainMenu");
    }

        public void Seleccion()
    {
    //Carga nivel
       SceneManager.LoadScene("Seleccion");
    }

        public void Ayuda()
    {
    //Carga nivel
       SceneManager.LoadScene("Ayuda");
    }




    public void Salir()
    {
    //Salida aplicacion
        Application.Quit();
    }
}
