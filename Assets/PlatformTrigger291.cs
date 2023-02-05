using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger291 : MonoBehaviour
{
    public GameObject Block291;
    public GameObject platformTrigger;
    public GameObject platform;
    public void OnTriggerEnter(Collider other)
    {
        platform.GetComponent<Animation>().Play("PlatformTrigger291");
        Block291.GetComponent<Animation>().Play("Block291");
        platformTrigger.SetActive(false);

    }
}
