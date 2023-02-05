using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger301 : MonoBehaviour
{
    public GameObject Block301;
    public GameObject platformTrigger;
    public GameObject platform;
    public void OnTriggerEnter(Collider other)
    {
        platform.GetComponent<Animation>().Play("PlatformTrigger301");
        Block301.GetComponent<Animation>().Play("Block301");
        platformTrigger.SetActive(false);
    }
}