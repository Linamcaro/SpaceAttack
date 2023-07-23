using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set;}

    /// <summary>
    /// Input Values
    /// </summary>

    public float Thrust { get; private set; }
    public float UpDown { get; private set;}
    public float Strafe { get; private set; }
    public float Roll { get; private set; }
    public Vector2 PitchYaw { get; private set; }

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
        Thrust = context.ReadValue<float>();

    }

    //helper function to call the Strafe controls
    public void OnStrafe(InputAction.CallbackContext context)
    {
        Strafe = context.ReadValue<float>();

    }

    //helper function to call the UpDown controls
    public void OnUpDown(InputAction.CallbackContext context)
    {
        UpDown = context.ReadValue<float>();
    }

    //helper function to call the Roll controls
    public void OnRoll(InputAction.CallbackContext context)
    {
        Roll = context.ReadValue<float>();
    }

    //helper function to call the Roll controls
    public void OnPitchYaw(InputAction.CallbackContext context)
    {
        PitchYaw = context.ReadValue<Vector2>();
    }

}
