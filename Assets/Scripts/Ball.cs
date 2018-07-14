using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private PaddleMovementHandler paddle;
    [SerializeField] private Vector2 launchVelocity = new Vector2(2f, 5f);

    private Rigidbody2D myRigidBody;

    private Vector3 posOffset;
    private bool ballLaunched = false;

    // Use this for initialization
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();

        posOffset = transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!ballLaunched)
        {
            StickToPaddle();
            LaunchBallOnClick();
        }
    }

    private void StickToPaddle()
    {
        transform.position = paddle.transform.position + new Vector3(posOffset.x, posOffset.y);
    }

    private void LaunchBallOnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myRigidBody.velocity = launchVelocity;
            ballLaunched = true;
        }
    }
}