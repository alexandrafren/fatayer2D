using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScriptableObjects : MonoBehaviour
{
    public OvenCounter counter;
    // Start is called before the first frame update
    void Start()
    {
        counter.value = 0;
    }
}
