﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [RequireComponent (typeof (Rigidbody))]
public class PlayerController : MonoBehaviour
{
    Vector3 velocity;
    Rigidbody myRigitbody;

    void Start()
    {
        myRigitbody = GetComponent<Rigidbody> ();  
    }

    
    public void Move(Vector3 _velocity) {
        velocity = _velocity;
    }

    public void LookAt(Vector3 lookPoint) {
        Vector3 heightCorrectPoint = new Vector3 (lookPoint.x, transform.position.y, lookPoint.z);
        transform.LookAt (heightCorrectPoint);
    }

    public void FixedUpdate() {
        myRigitbody.MovePosition (myRigitbody.position + velocity * Time.fixedDeltaTime);
    }
}
