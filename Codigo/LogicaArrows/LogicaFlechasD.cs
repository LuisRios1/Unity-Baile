using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaFlechasD : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.RightArrow)){
            if(adentro){
                GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntaje++;
                GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntajeS++;
                GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().texto.text = "Score: " + 
                    GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntaje.ToString();
                Destroy(gameObject);
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
