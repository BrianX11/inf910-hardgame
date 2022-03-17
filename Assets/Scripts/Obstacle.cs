using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public enum _animation
    {
        Triangle
    }

    public enum _direction
    {
        X,
        Y,
        Z
    }

    public _animation animation;
    public _direction direction;

    public float velocity = 10.0f;
    public float distance = 1.0f;
    public bool invert = false;

    private float tri;

    private Vector3 _startPosition;
    void Start()
    {
        _startPosition = transform.position;
    }

    void FixedUpdate()
    {
        switch (animation)
        {
            case _animation.Triangle:
                tri = Mathf.Asin(Mathf.Cos(Time.time * velocity)) * distance * (invert ? -1f : 1f);
                transform.position = _startPosition + new Vector3(
                    direction == _direction.X ? tri : 0.0f,
                    direction == _direction.Y ? tri : 0.0f,
                    0.0f
                    );
                break;
        }

    }
}
