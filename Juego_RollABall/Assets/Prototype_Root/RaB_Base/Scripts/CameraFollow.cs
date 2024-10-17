using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform followTarget; //Referencia al objeto que la cámara tiene que seguir
    public Vector3 offset; //Variable para almacenar la diferencia vectorial entre cámara y objetivo

    // Start is called before the first frame update
    void Start()
    {
        //El vector comparativo entre dos posiciones surge de :
        //Vector del objetivo - Vector original (en este caso, la scámara)
        offset = followTarget.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Los movimientos de cámara se suelen codear en el LateUpdate
        Follower();
    }

    void Follower()
    {
        //La posición de la cámara es igual a la posición del objeto
        transform.position = followTarget.position - offset;

    }
}
