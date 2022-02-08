using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutDough : MonoBehaviour
{
    public SpriteRenderer cutdoughSprite1;
    public SpriteRenderer cutdoughSprite2;
    public SpriteRenderer cutdoughSprite3;
    public Sprite newrecipe;
    public SpriteRenderer recipe;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "flatdough")
        {
            Destroy(col.gameObject);
            cutdoughSprite1.sortingOrder = 1;
            cutdoughSprite2.sortingOrder = 1;
            cutdoughSprite3.sortingOrder = 1;
            recipe.sprite = newrecipe;
        }
    }
}
