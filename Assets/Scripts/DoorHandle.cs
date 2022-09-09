using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandle : MonoBehaviour
{
    public Transform doorHandleGrab;
    public Rigidbody doorHandleFixedJoint_Rb;
    public Transform doorFixed;
    // Start is called before the first frame update

    private void FixedUpdate()
    {
        doorHandleFixedJoint_Rb.MovePosition(doorHandleGrab.position);
    }

    private void Start()
    {
        ReleaseHandle();
    }
    public void ReleaseHandle()
    {
        doorHandleGrab.position = doorFixed.position;
        doorHandleGrab.rotation = doorFixed.rotation;
        doorHandleFixedJoint_Rb.velocity = Vector3.zero;
        doorHandleFixedJoint_Rb.angularVelocity = Vector3.zero;
    }
}
