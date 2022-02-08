using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bake3D : MonoBehaviour
{
    public OvenCounter ovenCounter;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "uncookedfatayer")
        {
            Destroy(collision.gameObject);
            ovenCounter.value += 1;
        }
    }
}
