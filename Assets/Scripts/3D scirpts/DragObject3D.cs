using UnityEngine;
using System.Collections;

public class DragObject3D : MonoBehaviour
{
    public float forceAmount = 500;

    Rigidbody selectedRigidbody;
    Camera targetCamera;
    Vector3 originalScreenTargetPosition;
    Vector3 originalRigidbodyPos;
    float selectionDistance;
    bool doorOpen = false;

    public OvenCounter ovencount;

    // Start is called before the first frame update
    void Start()
    {
        targetCamera = GetComponent<Camera>();
    }

    void Update()
    {
        if (!targetCamera)
            return;
        if (Input.GetMouseButtonDown(0))
        {
            //Check if we are hovering over Rigidbody, if so, select it
            selectedRigidbody = GetRigidbodyFromMouseClick();
        }
        if (Input.GetMouseButtonUp(0) && selectedRigidbody)
        {
            //Release selected Rigidbody if there any
            selectedRigidbody = null;
        }
    }

    void FixedUpdate()
    {
        if (selectedRigidbody)
        {
            print(selectedRigidbody);
            Vector3 mousePositionOffset = targetCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, selectionDistance)) - originalScreenTargetPosition;
            selectedRigidbody.velocity = (originalRigidbodyPos + mousePositionOffset - selectedRigidbody.transform.position) * forceAmount * Time.deltaTime;
        }
    }

    Rigidbody GetRigidbodyFromMouseClick()
    {
        RaycastHit hitInfo = new RaycastHit();
        Ray ray = targetCamera.ScreenPointToRay(Input.mousePosition);
        bool hit = Physics.Raycast(ray, out hitInfo);
        if (hit)
        {
            if (hitInfo.collider.gameObject.GetComponent<Rigidbody>().tag == "oven")
            {
                if (doorOpen == false)
                {
                    hitInfo.collider.gameObject.GetComponent<Rigidbody>().transform.Rotate(-70.0f, 0.0f, 0.0f, Space.Self);
                    doorOpen = true;
                }
                else
                {
                    if (ovencount.value == 3)
                    {
                        hitInfo.collider.gameObject.GetComponent<Rigidbody>().transform.Rotate(70.0f, 0.0f, 0.0f, Space.Self);
                        doorOpen = false;
                    }
                }
            }
            else if (hitInfo.collider.gameObject.GetComponent<Rigidbody>())
            {
                selectionDistance = Vector3.Distance(ray.origin, hitInfo.point);
                originalScreenTargetPosition = targetCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, selectionDistance));
                originalRigidbodyPos = hitInfo.collider.transform.position;
                return hitInfo.collider.gameObject.GetComponent<Rigidbody>();
            }
        }

        return null;
    }
}

//Method found at: https://sharpcoderblog.com/blog/drag-rigidbody-with-mouse-cursor-unity-3d-tutorial