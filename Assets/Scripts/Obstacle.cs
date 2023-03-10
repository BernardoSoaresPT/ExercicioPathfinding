using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] float speed = .2f;
    [SerializeField] float strength = 9f;
    private float movementAmount;
    [SerializeField] bool movePositive;
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (movePositive)
        {
            pos.x = Mathf.Sin(Time.time * speed) * strength;
        }
        else
        {
            pos.x =-( Mathf.Sin(Time.time * speed) * strength);
        }
        transform.position = pos;
    }
}
