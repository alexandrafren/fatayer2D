using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillDough3D : MonoBehaviour
{
    public GameObject cutdoughSprite1;
    public GameObject cutdoughSprite2;
    public GameObject cutdoughSprite3;
    public AudioSource phonecall;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "circledough")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            cutdoughSprite1.SetActive(true);
        }
        if (col.gameObject.tag == "circledough2")
        {
            phonecall.Play();
            Destroy(col.gameObject);
            Destroy(gameObject);
            cutdoughSprite2.SetActive(true);
        }
        if (col.gameObject.tag == "circledough3")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            cutdoughSprite3.SetActive(true);

        }
    }
}
