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
    public Vector2 offset;
    

    private void Start()
    {
       previouscase = 0;
        offset = new Vector2(0.5f, 0f);

    }
    void Update()
    {
       // Debug.Log("pot 1 state" + StateTracker.pot1states);
       // Debug.Log("pot 2 state" + StateTracker.pot2states);
      //  Debug.Log("pot 3 state" + StateTracker.pot3states);
    }

    //onmousedown triggers 'thisevent'.
    private void OnMouseDown() 
    {
        thisevent();
 
    }
    //thisevent contains the list of sprites and a switch statement to swap between them. 
    protected virtual void thisevent()
    {
        switch (StateTracker.pot1states)
        {
            case 0:
                sr.sprite = sprites[0];
                break;
            case 1:
                if (previouscase == 0)
                {
                    //Debug.Log("filled with dirt");
                    sr.sprite = sprites[1];
                    previouscase = 1;
                }
                break;
            case 2:
                if (previouscase == 1)
                {
                    //Debug.Log("planted seeds");
                    sr.sprite = sprites[3];
                    previouscase = 2;
                }
                break;
            case 3:
                if (previouscase == 2)
                {
                    //Debug.Log("watered");
                    sr.sprite = sprites[2];
                    previouscase = 3;
                    StartCoroutine("growplants");
                }
                break;
        }
    }
    
    //this coroutine runs when case three is triggered. 
    public IEnumerator growplants()
    {

        // Debug.Log("coroutine started");

        //for the life of me I couldn't figure out why Pots 2 and 3 were'nt inheriting this code. 
        //I ran out of time to fix it.
        /*
        rb.position = rb.position + offset;
        yield return new WaitForSeconds(0.2f);
        rb.position = rb.position - offset;
        yield return new WaitForSeconds(0.2f);
        rb.position = rb.position - offset;
        yield return new WaitForSeconds(0.2f);
        rb.position = rb.position + offset;
        yield return new WaitForSeconds(0.2f);
        rb.position = rb.position + offset;
        yield return new WaitForSeconds(0.2f);
        rb.position = rb.position - offset;
       */

        yield return new WaitForSeconds(2);

        sr.sprite = sprites[4];
        yield return new WaitForSeconds(5);
        StateTracker.pot1states = 0;
        StateTracker.pot2states = 0;
        StateTracker.pot3states = 0;
        //Debug.Log("reset potstates");
        sr.sprite = sprites[0];
        previouscase = 0;
    }

}
