using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 20;
    public float velGiro = 20;
    private float avanza;
    private float gira;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        avanza = Input.GetAxis("Vertical"); //para avanzar adelante y para atras
        gira = Input.GetAxis("Horizontal"); //para girar

        transform.Translate(Vector3.forward*Time.deltaTime*velocidad*avanza); //Solo se mueve la Z
        transform.Rotate(Vector3.up*Time.deltaTime*velGiro*gira);
    }
}
