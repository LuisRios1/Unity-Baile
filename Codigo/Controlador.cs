using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{

    private Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        timer=gameObject.GetComponent<Timer>();
    }

    public void StartGamer(){
        timer.startTimer();
    }
}
