using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Pot : MonoBehaviour
{
    public Rigidbody2D rb;
   public BoxCollider2D bc;
   public SpriteRenderer sr;
    public List<Sprite> sprites;
    

    private void Start()
    {
       // sr.sprite= sprites[6];

    }
    private void OnMouseDown() 
    {
        thisevent();
 
    }
    protected virtual void thisevent()
    {
        switch (StateTracker.pot1states)
        {
            case 0:
                return;
            case 1:
                Debug.Log("filled with dirt");
                sr.sprite = sprites[1];
                break;
            case 2:
                Debug.Log("planted seeds");
                sr.sprite = sprites[2];
                break;
            case 3:
                Debug.Log("watered");
                sr.sprite = sprites[3];
                StateTracker.pot1states = 4;
                break;
            case 4:
                Debug.Log("growing");
                sr.sprite = sprites[4];
                break;


        }
    }

}
