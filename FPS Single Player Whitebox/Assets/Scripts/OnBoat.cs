using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBoat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!BoatTravel.OnTheBoat)
        {
            gameObject.transform.parent = null;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Boat"))
        {
            BoatTravel.OnTheBoat = true;
            transform.SetParent(collision.gameObject.transform);
        }
    }
}
