using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus2 : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.E)){
            if(adentro){
                if(GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntaje <= 0){
                    GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntaje=0;
                    GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().texto.text = "Score: " + 
                        GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntaje.ToString();
                    Destroy(gameObject);
                        if(GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntajeS <= 25){
                            GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntajeS = 25;
                        }
                } else {
                    GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntaje-=2;
                    GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().texto.text = "Score: " + 
                        GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntaje.ToString();
                    Destroy(gameObject);
                    GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntajeS -=2;
                }

            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player2"){
            contador++;
            //Debug.Log("entro");
        }
    }

        public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player2"){
            contador--;
        }
    }
}
