using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaGeneradorEnemigos : MonoBehaviour
{

    public GameObject[] flechas;
    private float tiempoEntreFlechas;
    public float comienzoDeTiempo;

    void Start(){

    }

    void Update()
    {
        if(tiempoEntreFlechas <= 0)
        {
            int random = Random.Range(0, flechas.Length);
            Instantiate(flechas[random], transform.position, Quaternion.identity);

            tiempoEntreFlechas = comienzoDeTiempo;

        }
        else
        {
            tiempoEntreFlechas -= Time.deltaTime;
        }
    }
}
