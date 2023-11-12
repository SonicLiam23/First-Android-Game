using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{

    public GameObject obstacle;
    int cooldown;
    float timer = 0f;
    bool MoveLeft = false;

    private void Start()
    {
        cooldown = Random.Range(1, 4);
    }
    // Update is called once per frame
    void Update()
    {
        if (timer >= cooldown)
        {
            GameObject.Instantiate(obstacle, transform.position, transform.rotation, null);
            timer = 0f;
            cooldown = Random.Range(2, 5);
        }
        else
        {
            timer += Time.deltaTime;            
        }
        if (MoveLeft)
        {
            transform.position = new Vector3(transform.position.x - Time.deltaTime, transform.position.y, transform.position.z);
            if (transform.position.x <= -2.5)
            {
                MoveLeft = false;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x + Time.deltaTime, transform.position.y, transform.position.z);
            if (transform.position.x >= 2.5)
            {
                MoveLeft = true;
            }
        }
    }
}
