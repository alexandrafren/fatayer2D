using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillDough : MonoBehaviour
{
    public SpriteRenderer cutdoughSprite1;
    public SpriteRenderer cutdoughSprite2;
    public SpriteRenderer cutdoughSprite3;
    public Sprite newrecipe;
    public SpriteRenderer recipe;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "circledough")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            cutdoughSprite1.sortingOrder = 1;
        }
        if (col.gameObject.tag == "circledough2")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            cutdoughSprite2.sortingOrder = 1;
        }
        if (col.gameObject.tag == "circledough3")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            cutdoughSprite3.sortingOrder = 1;
            recipe.sprite = newrecipe;
        }
    }
}
