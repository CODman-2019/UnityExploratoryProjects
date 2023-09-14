using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TwoDimensionalPlatformController : MonoBehaviour
{
    Rigidbody rb;
    PlayerInput input;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        input = GetComponent<PlayerInput>();
        input.SwitchCurrentActionMap("PlayerController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(InputAction.CallbackContext context)
    {
        Debug.Log(context.ReadValue<float>());
        transform.Translate(Vector3.right * context.ReadValue<float>() * Time.deltaTime);
    }
}
