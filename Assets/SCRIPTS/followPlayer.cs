using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    private Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.Find("PLAYER").transform;
    }

    void LateUpdate()
    {
        transform.position = playerTransform.position;
    }
}
