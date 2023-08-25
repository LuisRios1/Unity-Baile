using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicaJ1 : MonoBehaviour
{
    public float puntaje = 25f, puntajeS = 50f;
    public TextMeshProUGUI texto;
    public int contador = 0;
    public bool adentro = false;
    public float puntajeF = 0f;

    void Start(){
        texto = GameObject.Find("ScoreUI").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
       
    }
}
