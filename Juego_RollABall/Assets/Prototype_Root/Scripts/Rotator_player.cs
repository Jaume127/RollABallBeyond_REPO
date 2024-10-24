using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float rotSpeedX;
    public float rotSpeedY;
    public float rotSpeedZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * rotSpeedX * Time.deltaTime);
        transform.Rotate(Vector3.up * rotSpeedY * Time.deltaTime);
        transform.Rotate(Vector3.left * rotSpeedZ * Time.deltaTime);
    }
}
