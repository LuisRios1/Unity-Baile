using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus1 : MonoBehaviour
{

    public float velocidad;
    public int contador = 0;
    public bool adentro = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right*velocidad * Time.deltaTime;
        if(contador == 2)
        {
            adentro = true;
        }
        else
        {
            adentro = false;
        }
        if (Input.GetKeyDown(KeyCode.RightControl)){
            if(adentro){
                if(GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().puntaje<=0){
                GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().puntaje=0;
                GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().texto.text = "Score: " + 
                    GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().puntaje.ToString();
                Destroy(gameObject);
                    if (GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().puntajeS <= 25){
                        GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().puntajeS = 25;
                    }   
            } else {
                GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().puntaje-=2;
                GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().texto.text = "Score: " + 
                    GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().puntaje.ToString();
                Destroy(gameObject);
                GameObject.Find("CasillaJugador2").GetComponent<LogicaJ2>().puntajeS -=2;
            }

            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player"){
            contador++;
            //Debug.Log("entro");
        }
    }

        public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player"){
            contador--;
        }
    }
}
