using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollDough3D : MonoBehaviour
{
    public GameObject flatdough;
    public AudioSource phonecall;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "dough")
        {
            Destroy(collision.gameObject);
            flatdough.SetActive(true);
            phonecall.Play();
        }
    }
}
