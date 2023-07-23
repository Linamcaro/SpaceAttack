using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [Header("SpaceShip Movement")]
    //force that causes the spaceship to rotate around its y axis
    [SerializeField] private float yawTorque = 500f;
    //rotational force that causes the spaceship to tilt up or down the x axis
    [SerializeField] private float pitchTorque = 1000f;
    //rotational force that causes the spacecraft to spin around the z axis
    [SerializeField] private float rollTorque = 1000f;
    //force that moves the spaceship through space
    [SerializeField] private float thrust = 100f;
    [SerializeField] private float upThrust = 50f;
    //move sideways
    [SerializeField] private float strafeThrust = 50f;
    //How fast we slowDown
    [SerializeField, Range(0.001f, 0.999f)] private float thrustGlideReduction = 0.999f;
    [SerializeField, Range(0.001f, 0.999f)] private float upThrustGlideReduction = 0.111f;
    [SerializeField, Range(0.001f, 0.999f)] private float strafeGlideReduction = 0.111f;

    private Rigidbody playerRb;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void FixUpdate()
    {
       PlayerMovement();
    }

    private void PlayerMovement()
    {
        playerRb.AddRelativeTorque
    }


}
