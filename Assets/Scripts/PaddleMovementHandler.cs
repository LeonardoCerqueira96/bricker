using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovementHandler : MonoBehaviour
{
    [SerializeField] private float leftXLimit = 1f;
    [SerializeField] private float rightXLimit = 15f;

    // Update is called once per frame
    void Update()
    {
        MoveToMousePos();
    }

    private void MoveToMousePos()
    {
        Vector2 mouseScreenPos = new Vector2(Input.mousePosition.x, 0f);
        float worldXPos = Camera.main.ScreenToWorldPoint(mouseScreenPos).x;
        worldXPos = Mathf.Clamp(worldXPos, leftXLimit, rightXLimit);

        transform.position = new Vector2(worldXPos, transform.position.y);
    }
}
