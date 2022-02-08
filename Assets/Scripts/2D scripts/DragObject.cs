using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 mousePos;
    public bool isBeingHeld = false;

    // Update is called once per frame
    void Update()
    {
        if(isBeingHeld == true)
        {
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x, mousePos.y, 0);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
    }
}
