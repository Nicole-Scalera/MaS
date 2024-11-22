using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Rigidbody2D _rigidbody;
    private Vector2 _movementInput;
    private Vector2 _smoothedMovementInput;
    private Vector2 _movementInputSmoothVelocity;
    private bool facingLeft = true;

    //get rigid body from unity
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Movement & smoothed movement
    private void FixedUpdate()
    {

        _smoothedMovementInput = Vector2.SmoothDamp(
             _smoothedMovementInput,
             _movementInput,
             ref _movementInputSmoothVelocity,
             0.08f);

        _rigidbody.velocity = _smoothedMovementInput * _speed;

        // Determine character direction:
        // if (_movementInput != 0)
        // {
        //      _rigidbody.AddForce(new Vector2(inputHorizontal * _speed, 0f))
        // }
        // if (_movementInput > 0)
        // {
        //      Flip();
        // }
        // if (_movementInput < 0)
        // {
        //      Flip();
        // }

    }

    // Get player input value from Unity
    private void OnMove(InputValue inputValue)
    {
        _movementInput = inputValue.Get<Vector2>();

    }

    private void Update()
    {
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            Flip();
        }

        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            if (!facingLeft)
            {
                Flip();
            }
        }
    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;

        facingLeft = !facingLeft;
    }
}