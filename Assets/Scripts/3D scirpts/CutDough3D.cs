using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutDough3D : MonoBehaviour
{
    public GameObject cutdoughSprite1;
    public GameObject cutdoughSprite2;
    public GameObject cutdoughSprite3;
    public AudioSource phonecall;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "flatdough")
        {
            Destroy(collision.gameObject);
            cutdoughSprite1.SetActive(true);
            cutdoughSprite2.SetActive(true);
            cutdoughSprite3.SetActive(true);
            phonecall.Play();
        }
    }
}
