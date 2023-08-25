using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BarraDeVida1S : MonoBehaviour
{
    public Image barradevida;
    public float maxv, av;

    // Update is called once per frame
    void Update()
    {
        av =  GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntajeS + 2;
        barradevida.fillAmount = av/maxv;

    }
}
