using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicaJ2 : MonoBehaviour
{
    public float puntaje = 25f, puntajeS = 50f;
    public TextMeshProUGUI texto;
    public int contador = 0;
    public bool adentro = false;
    public float puntajeF = 0f;

    void Start(){
        texto = GameObject.Find("ScoreUI1").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        
    }
}
