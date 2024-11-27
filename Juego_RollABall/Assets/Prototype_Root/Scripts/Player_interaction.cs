using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Librería para poder referenciar elementos de User Interface.
using TMPro; //Librería para poder referenciar elementos de Text Mes Pro

public class Playerinteraction : MonoBehaviour
{



    [Header("UI References")]
    public TMP_Text pointsText; //Ref al texto de UI que quiero que cambie dinamicamente según los puntos del player


    [Header("Point System Parameters")]
    // Variables para definir los puntos del jugador
    public int currentPoints;
    public int winPoints;
    public GameObject winGoal;


    [Header("Respawn Parameters")]
    public Transform respawnPoint;
    public float respawnFallLimit;



    private void Update()
    {
        if (currentPoints < 0) { currentPoints = 0; }
        if (transform.position.y <= respawnFallLimit) { Respawn(); }
        if (currentPoints >= winPoints) { winGoal.SetActive(true); }
        UIUpdater();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            currentPoints += 1;
            other.gameObject.SetActive(false);
            // Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("PickDown"))
        {
            currentPoints -= 1;
            other.gameObject.SetActive(false);

        }


    }

    void UIUpdater()
        {
            pointsText.text = "Points: " + currentPoints.ToString() + "/" + winPoints.ToString();
        }

    void Respawn()
    {
        transform.position = respawnPoint.position;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

 
}
