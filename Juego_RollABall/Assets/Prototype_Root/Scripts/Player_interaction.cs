using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Librería para poder referenciar elementos de User Interface.
using TMPro; //Librería para poder referenciar elementos de Text Mes Pro

public class Playerinteraction : MonoBehaviour
{


[Header("Point System Parameters")]
    // Variables para definir los puntos del jugador
    public int currentPoints;
    public int winPoints;




     private void Update()
    {
        if (currentPoints < 0) { currentPoints = 0; }
     
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            currentPoints += 1;
            other.gameObject.SetActive(false);
            // Destroy(other.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

 
}
