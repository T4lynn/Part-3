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
    protected int previouscase;
    

    private void Start()
    {
       previouscase = 0;

    }
    void Update()
    {
        Debug.Log("pot 1 state" + StateTracker.pot1states);
        Debug.Log("pot 2 state" + StateTracker.pot2states);
        Debug.Log("pot 3 state" + StateTracker.pot3states);
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
                break;
            case 1:
                if (previouscase == 0)
                {
                    Debug.Log("filled with dirt");
                    sr.sprite = sprites[1];
                    previouscase = 1;
                }
                break;
            case 2:
                if (previouscase == 1)
                {
                    Debug.Log("planted seeds");
                    sr.sprite = sprites[3];
                    previouscase = 2;
                }
                break;
            case 3:
                if (previouscase == 2)
                {
                    Debug.Log("watered");
                    sr.sprite = sprites[2];
                    StateTracker.pot1states = 4;
                    previouscase = 3;
                }
                break;
            case 4:
                if (previouscase == 3)
                {
                    Debug.Log("growing");
                    sr.sprite = sprites[4];
                    previouscase = 4;
                }
                break;
        }
    }

}
