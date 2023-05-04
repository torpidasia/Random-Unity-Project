using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girl : MonoBehaviour
{
    float speed = 0.7f;
    Vector2 destinationPosition;

    // Start is called before the first frame update
    void Start()
    {
        destinationPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destinationPosition, speed);
    }

    public void setGirlPosition(Vector2 destinationPosition)
    {
       
        transform.position = destinationPosition;
    }
    public void moveGirl(Vector2 pDestinationPosition)
    {
        destinationPosition = pDestinationPosition;
    }
}
