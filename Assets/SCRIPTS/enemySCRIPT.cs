using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySCRIPT : MonoBehaviour
{
    public float speed;
    private Rigidbody _rigidbody;
    private GameObject player;
    private int limit = -3;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        player = GameObject.Find("PLAYER");
    }

    void Update()
    {
        //cream un nou vector que serà es recorregut en tot moment de player (A) i enemy (B) --> AB
        Vector3 direction = (player.transform.position - transform.position).normalized;
        _rigidbody.AddForce(direction * speed);

        if(transform.position.y < limit)
        {
            Destroy(gameObject);
        }
    }
}
