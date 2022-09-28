/*
Florentino Ramirez Balderas
1219100383 | GDGS2021 | 14/09/2022

Descripcion: Se crea la funcionalidad para que el coche tenga movimientos, como avansar hacia delante 
y para atras, tambien que pueda girar a la izquierda o a la derecha dependiendo de la combinacion de 
las teclas. 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Se crean las variables para avansar, retoceder y girar
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

        transform.Translate(Vector3.forward*Time.deltaTime*velocidad*avanza); //Solo mueve el eje Z para avansar
        transform.Rotate(Vector3.up*Time.deltaTime*velGiro*gira);// funcion para poder girar
    }
}
