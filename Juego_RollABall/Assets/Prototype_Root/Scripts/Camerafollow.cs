using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{

    public Transform objectFollowed;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = objectFollowed.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Follower();
    }


    void Follower()
    {
        transform.position = objectFollowed.position - offset;
    }
}
