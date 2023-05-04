using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catrandom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        generaterRandomCat();
       
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "chibi")
        {
            Debug.Log("umar dumb, haha in your dreams");
            generaterRandomCat();
        }
    }
    void generaterRandomCat()
    {
        Vector2 newPos;
        float x = Random.Range(-9.7f, 9.7f);
        float y = Random.Range(-3.2f, 3.2f);
        newPos = new Vector2(x,y);
        transform.position = newPos;
    }
}
