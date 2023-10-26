using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Destruct : MonoBehaviour
{

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Trigger");
        if (collision.gameObject.tag.Equals("DestructTrigger"))
        {
            Destroy(collision.gameObject);
            Debug.Log("Destroyed");
        }
    }

}
