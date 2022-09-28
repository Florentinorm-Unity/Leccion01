/*
Florentino Ramirez Balderas
1219100383 | GDGS2021 | 14/09/2022

Descripcion: Se crea el movimiento de la camara para que siga el tanque
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public GameObject tanque;
    
    // se crean los vectores en la posision donde se encuentra la camara
    public Vector3 upCam = new Vector3(0,10,-10);  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // se transorfa la posision en vectores
        transform.position = tanque.transform.position + upCam;
    }
}
