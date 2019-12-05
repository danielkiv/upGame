//script for the flame to move accross the map
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFlame : MonoBehaviour
{
    //vars
    public Transform start, end;
    public float speed;
    public Transform startPoint;
    Vector3 next;

    // Start is called before the first frame update
    void Start()
    {
        next = startPoint.position;
    }

    // Update is called once per frame
    //move the flame from start spot to end spot
    void Update()
    {
        if(transform.position == start.position)
        {
            next = end.position;
        }
        if(transform.position == end.position)
        {
            next = start.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, next, speed * Time.deltaTime);
    }
}
