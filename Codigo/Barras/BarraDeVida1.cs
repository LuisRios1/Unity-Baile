using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida1 : MonoBehaviour
{

    public Image barradevida;
    public float maxv, av;

    // Update is called once per frame
    void Update()
    {
        av =  GameObject.Find("CasillaJugador").GetComponent<LogicaJ1>().puntaje + 2;
        barradevida.fillAmount = av/maxv;

    }
}
