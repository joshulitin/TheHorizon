using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger2881 : MonoBehaviour
{
    public GameObject movingPlatform;
    public GameObject platformTrigger;
    public GameObject platform;
    public void OnTriggerEnter(Collider other)
    {
        movingPlatform.GetComponent<Animation>().Play("MovingPlatform2883");
        platform.GetComponent<Animation>().Play("PlatformTrigger2881");
        platformTrigger.SetActive(false);
    }
}
