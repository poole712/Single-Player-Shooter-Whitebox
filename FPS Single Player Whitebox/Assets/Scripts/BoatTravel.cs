using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatTravel : MonoBehaviour
{
    Animator boatMator;
    public static bool OnTheBoat;
    // Start is called before the first frame update
    void Start()
    {
        OnTheBoat = false;
        boatMator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.boatMator.GetCurrentAnimatorStateInfo(0).IsName("AtDestination"))
        {
            OnTheBoat = false;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            OnTheBoat = true;
            boatMator.SetTrigger("PlayerOnBoard");
        }
    }
}
