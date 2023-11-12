using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{

    public GameObject obstacle;
    int cooldown;
    float timer = 0f;
    bool MoveLeft = false;
    int speed = 0;

    private void Start()
    {
        // cooldown = Random.Range(1, 4);
        speed = Random.Range(1, 6);
        cooldown = 2;
    }
    // Update is called once per frame
    void Update()
    {
        if (timer >= cooldown)
        {
            GameObject.Instantiate(obstacle, transform.position, transform.rotation, null);
            timer = 0f;
            // cooldown = Random.Range(2, 5);
        }
        else
        {
            timer += Time.deltaTime;            
        }

        //moves spawner left and right
        if (MoveLeft)
        {
            transform.position = new Vector3(transform.position.x - Time.deltaTime * speed, transform.position.y, transform.position.z);
            if (transform.position.x <= -2.5)
            {
                MoveLeft = false;
                speed = Random.Range(1, 6);
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x + Time.deltaTime * speed, transform.position.y, transform.position.z);
            if (transform.position.x >= 2.5)
            {
                MoveLeft = true;
                speed = Random.Range(1, 6);
            }
        }
    }
}
