using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set;}

    /// <summary>
    /// Input Values
    /// </summary>

    public float thrust { get; private set; }
    public float upDown { get; private set;}
    public float strafe { get; private set; }
    public float roll { get; private set; }
    public Vector2 pitchYaw { get; private set; }

    private void Awake()
    {

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

    }

    
    //helper function to call the player movement controls
    public void OnThrust(InputAction.CallbackContext context)
    {
        thrust = context.ReadValue<float>();

    }

    //helper function to call the Strafe controls
    public void OnStrafe(InputAction.CallbackContext context)
    {
        strafe = context.ReadValue<float>();

    }

    //helper function to call the UpDown controls
    public void OnUpDown(InputAction.CallbackContext context)
    {
        upDown = context.ReadValue<float>();
    }

    //helper function to call the Roll controls
    public void OnRoll(InputAction.CallbackContext context)
    {
        roll = context.ReadValue<float>();
    }

    //helper function to call the Roll controls
    public void OnPitchYaw(InputAction.CallbackContext context)
    {
        pitchYaw = context.ReadValue<Vector2>();
    }

}
