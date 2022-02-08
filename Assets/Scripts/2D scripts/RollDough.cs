using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollDough : MonoBehaviour
{
    public SpriteRenderer flatdoughSprite;
    public Sprite newrecipe;
    public SpriteRenderer recipe;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "dough")
        {
            recipe.sprite = newrecipe;
            Destroy(col.gameObject);
            flatdoughSprite.sortingOrder = 1;
        }
    }

}
