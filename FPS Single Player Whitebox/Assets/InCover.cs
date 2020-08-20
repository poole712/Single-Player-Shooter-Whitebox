using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InCover : MonoBehaviour
{
    public static bool playerBehindCover;

    // Start is called before the first frame update
    void Start()
    {
        playerBehindCover = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("LowCover"))
        {
            playerBehindCover = true;
        }
        else
        {
            playerBehindCover = false;
        }
    }
}
