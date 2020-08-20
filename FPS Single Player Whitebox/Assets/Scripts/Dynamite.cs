using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dynamite : MonoBehaviour
{
    public bool hasDynamite;
    public GameObject wallToBlow;
    public AudioSource countDown;
    // Start is called before the first frame update
    void Start()
    {
        hasDynamite = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && other.CompareTag("Dynamite"))
        {
            hasDynamite = true;
        }
        if (Input.GetKeyDown(KeyCode.E) && hasDynamite && other.CompareTag("PlantZone"))
        {
            wallToBlow = other.gameObject;
            StartCoroutine(BlowUpWall());
        }
    }
    IEnumerator BlowUpWall()
    {
        countDown.Play();
        yield return new WaitForSeconds(5);
        Destroy(wallToBlow);
    }
}
