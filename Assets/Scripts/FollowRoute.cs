using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRoute : MonoBehaviour
{
    //[SerializeField]

    public Transform[] marks;
    public float speed;
    Vector2 target;
    int index = 1;
    string direction = "front";
    int size;

    private void Start()
    {
        size = marks.Length;
    }
    void Update()
    {
        target = marks[index].transform.position;
        transform.position = Vector2.MoveTowards(transform.position, target, speed);

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (direction == "front")
        {
            index += 1;
        } else if (direction == "back")
        {
            index -= 1;
        }

        if (index == size)
        {
            direction = "back";
            index -= 2;
        }
        if (index == 0)
        {
            direction = "front";
            index += 2;
        }
    }
}
