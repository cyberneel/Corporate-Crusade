using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private PlayerController controller;
    private PlayerInput input;

    private Vector2 velocity;

    private void Awake()
    {
        controller = GetComponent<PlayerController>();
        input = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        velocity = input.actions["move"].ReadValue<Vector2>().normalized;
    }

    private void FixedUpdate()
    {
        controller.Move(velocity * moveSpeed);
    }
}
