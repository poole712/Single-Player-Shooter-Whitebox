using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dynamite : MonoBehaviour
{
    public Image dynamiteSprite;
    public bool hasDynamite;
    public GameObject wallToBlow;
    public AudioSource countDown;
    // Start is called before the first frame update
    void Start()
    {
        dynamiteSprite.enabled = false;
        hasDynamite = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (hasDynamite)
        {
            dynamiteSprite.enabled = true;
        }
        else
        {
            dynamiteSprite.enabled = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && other.CompareTag("Dynamite"))
        {
            hasDynamite = true;
        }
        if (Input.GetKeyDown(KeyCode.E) && hasDynamite && other.CompareTag("PlantZone"))
        {
            hasDynamite = false;
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
