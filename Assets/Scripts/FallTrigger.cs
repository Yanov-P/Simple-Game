using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger enter " + other.gameObject.name);
        if(other.tag == "Player")
        {
            other.GetComponent<PlayerControls>().Respawn();
        }
    }
}
