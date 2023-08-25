using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaPersonaje1 : MonoBehaviour
{
    public KeyCode der, izq, arr, aba, E;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate(){
        if(Input.GetKeyDown(der)){
            anim.SetTrigger ("Derecha");
        }

        if(Input.GetKeyDown(izq)){
            anim.SetTrigger ("Izquierda");
        }

        if(Input.GetKeyDown(arr)){
            anim.SetTrigger ("Arriba");
        }

        if(Input.GetKeyDown(aba)){
            anim.SetTrigger ("Abajo");
        }  

        if(Input.GetKeyDown(E)){
            anim.SetTrigger ("E");
        }  
    }
}
