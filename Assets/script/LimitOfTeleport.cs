using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfLimitTeleport : MonoBehaviour
{

    public int heightToTeleport = -10;
    public Transform objectToMove;
    public Transform whereToRespwan;
    public Rigidbody rigidbodyOfCharater;

    void Start()
    {

    }

    void Update()
    {

        if (objectToMove.position.y < heightToTeleport)
        {

            objectToMove.position = whereToRespwan.position;
            rigidbodyOfCharater.velocity = Vector3.zero;



        }
    }
}



