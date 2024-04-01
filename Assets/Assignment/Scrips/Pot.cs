using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Pot : MonoBehaviour
{
    public Rigidbody2D rb;
   public BoxCollider2D bc;
   public SpriteRenderer sr;
    Color primarycolor;
    Color secondarycolor;

    private void Start()
    {
       primarycolor = sr.color;
        secondarycolor = Color.red;
    }
    private void OnMouseDown()
    {
        Debug.Log("filled with dirt");
        sr.color = secondarycolor;
    }
}
