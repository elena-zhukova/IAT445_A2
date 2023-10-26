using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    private void Start()
    {
        GameObject house = GameObject.FindGameObjectWithTag("House");
        Physics.IgnoreCollision(house.GetComponent<Collider>(), GetComponent<Collider>());
    }
}
