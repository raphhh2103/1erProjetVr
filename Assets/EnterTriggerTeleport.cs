

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTriggerTeleport : MonoBehaviour
{

    public Transform respawn;

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            Debug.DrawLine(other.transform.position, other.transform.position + new Vector3(0, 50000, 0), Color.red, 30);

            other.transform.position = respawn.position;

            Rigidbody rig = GetComponent<Rigidbody>();
            if (rig != null)
            {

                rig.velocity = Vector3.zero;
            }


            Debug.Log("Player enter trigger", this.gameObject);

        }
    }
}

