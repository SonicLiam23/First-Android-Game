using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{

    Vector3 fingerPos = Vector2.zero;
    Vector3 forceVector;
    public Rigidbody2D rigid;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            fingerPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 distance = fingerPos - this.transform.position;
            forceVector = distance.normalized * 100;
            rigid.AddForce(forceVector * Time.deltaTime);
        }

    }
}