using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogue : MonoBehaviour
{

    public Image image;
    public Image image2;
    private bool message1done = false;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (message1done == false) {
                image.enabled = false;
                image2.enabled = true;
                message1done = true;
            }
            else
            {
                image2.enabled = false;
            }
        }
    }
}
