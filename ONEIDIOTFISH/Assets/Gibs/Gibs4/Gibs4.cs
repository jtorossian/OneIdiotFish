using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gibs4 : MonoBehaviour {
    private Vector3 updatedPosition;
    public float speed;
    // Use this for initialization
    void Start()
    {
        speed = 3;
        transform.localScale = new Vector3(.3f, .3f, 1);
    }

    // Update is called once per frame
    void Update()
    {
        updatedPosition = new Vector2(transform.position.x - 15, transform.position.y + 5);
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), updatedPosition, speed * Time.deltaTime);
        transform.Rotate(Vector3.forward * Time.deltaTime * 50);
    }
}