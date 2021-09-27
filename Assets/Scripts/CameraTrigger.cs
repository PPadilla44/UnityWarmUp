using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{

    public GameObject camera;

    private void OnTriggerStay(Collider other)
    {
        if(other)
        {
            camera.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other)
        {
            camera.SetActive(false);
        }
    }
}
