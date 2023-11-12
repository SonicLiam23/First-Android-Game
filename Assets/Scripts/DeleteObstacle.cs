using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObstacle : MonoBehaviour
{

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject.Destroy(collision.gameObject);
    }

}
