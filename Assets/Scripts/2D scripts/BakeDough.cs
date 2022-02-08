using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BakeDough : MonoBehaviour
{
    public Sprite newrecipe;
    public SpriteRenderer recipe;
    public Animator ani;
    public OvenCounter ovencount;


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "oven")
        {
            ani.SetBool("baking", true);
            recipe.sprite = newrecipe;
            ovencount.value += 1;
        }
    }



}
