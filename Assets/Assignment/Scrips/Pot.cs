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
    Color thirdcolor;
    Color fourthcolor;
    

    private void Start()
    {
       primarycolor = sr.color;
        secondarycolor = Color.red;
        thirdcolor = Color.green;
        fourthcolor = Color.blue;

    }
    private void OnMouseDown()
    {
        switch (StateTracker.pot1states)
        {
            case 0:
                return;
            case 1:
                Debug.Log("filled with dirt");
                sr.color = secondarycolor;
                break;
            case 2:
                Debug.Log("planted seeds");
                sr.color = thirdcolor;
                break;
            case 3:
                Debug.Log("watered");
                sr.color = fourthcolor;
                break;


        }
 
    }

}
