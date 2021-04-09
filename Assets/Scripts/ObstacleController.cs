using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float moveSpeed = 1f;

    private void Update()
    {
        transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
    }
}
