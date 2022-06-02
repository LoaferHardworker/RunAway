using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    private Rigidbody _rb;
    private Controls _controls;

    public float jumpHeight;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Awake()
    {
        _controls = new Controls();
        _controls.Player.Jump.started += Jump;
    }

    private void OnEnable() => _controls.Enable();

    private void OnDisable() => _controls.Disable();

    private void Jump(InputAction.CallbackContext obj)
    {
        _rb.velocity = Vector3.up * jumpHeight;
    }
}
