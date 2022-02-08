using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bake : MonoBehaviour
{
    public GameObject button;
    public OvenCounter ovencount;

    // Update is called once per frame
    void Start()
    {
        button.SetActive(false);
    }

    void Update()
    {
        if (ovencount.value == 3)
        {
            StartCoroutine(FinishBake());
  
        }
    }

    IEnumerator FinishBake()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("EndScene");
    }

}