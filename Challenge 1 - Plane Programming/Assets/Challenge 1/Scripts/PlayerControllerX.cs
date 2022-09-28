/*
Florentino Ramirez Balderas
GDGS2021 | 1219100383 | 17/09/2022
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20;
    public float rotationSpeed;
    public float verticalInput;

    // Inicia los frame
    void Start()
    {

    }

    // La actualizacion se lleva una por cuadro
    void FixedUpdate()
    {
        // Se obtiene la entrada vertical
        verticalInput = Input.GetAxis("Vertical");

        // mueve el avion hacia adelante a una velocidad constante 
        transform.Translate(Vector3.forward * speed * Time.deltaTime);//agrege el * Time.deltaTime

        // hace girar al avion hacia arriba o abajo
      transform.Rotate(Vector3.right, Time.deltaTime * rotationSpeed * verticalInput);//punto 3 listo

     
    }
}
