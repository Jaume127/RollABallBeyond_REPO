using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towermove : MonoBehaviour
{
    // Velocidad de rotación
    public float rotationSpeed = 100f;

    void Update()
    {
        // Detectar entrada del usuario para rotar sobre el eje Z
        if (Input.GetKey(KeyCode.L))
        {
            // Rotar hacia la izquierda sobre el eje Z (negativo)
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.J))
        {
            // Rotar hacia la derecha sobre el eje Z (positivo)
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
    }
}
