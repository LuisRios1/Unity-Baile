using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicaEscena : MonoBehaviour
{
    public int contador1;
    public int contador2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Flecha2"){
            contador2++;
            if(GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().puntaje <= 0){
                GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().puntaje = 0;
                GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().texto.text = "Score: " + 
                    GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().puntaje.ToString();
                Destroy(GameObject.Find("Flecha2"));
                if (GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().puntajeS <= 25){
                    GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().puntajeS = 25;
                }
            } else{
                if(contador2 == 2){
                GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().puntaje -= 1;
                GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().texto.text = "Score: " + 
                    GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().puntaje.ToString();
                Destroy(GameObject.Find("Flecha2"));
                GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().puntajeS -= 1;   
                }
            }
        }

            if(collision.gameObject.tag=="Flecha"){
                contador1++;
                if(GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntaje <= 0){
                    GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntaje = 0;
                        GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().texto.text = "Score: " + 
                    GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntaje.ToString();
                    Destroy(GameObject.Find("Flecha"));
                    if(GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntajeS <= 25){
                        GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntajeS = 25;
                    }
                } else{
                if(contador1 == 2){
                    GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntaje -= 1;
                    GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().texto.text = "Score: " + 
                        GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntaje.ToString();
                    Destroy(GameObject.Find("Flecha"));
                    GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntajeS -= 1;
                }
            }      
        }
    }

        public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Flecha2"){
            contador2--;
        }
        if(collision.gameObject.tag=="Flecha"){
            contador1--;
        }
    }
}
