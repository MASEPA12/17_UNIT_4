using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float speed = 30f;
    private float forwardInput;
    private Rigidbody _rigidBody;
    public GameObject focalPoint;

    public float powerUpforce;
    public bool hasPowerUp;

    public GameObject[] powerUPindicators;
    

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("focalPOINT");
    }

    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        _rigidBody.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("POWERup"))
        {
            StartCoroutine(PowerUpCountDown());
            hasPowerUp = true;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("powerUP2"))
        {

        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("ENEMY") && hasPowerUp)
        {
            Rigidbody enemyRigidbody = other.gameObject.GetComponent<Rigidbody>();

                                                          //enemyposition -  playerposition
            Vector3 awayFromPlayer = (other.gameObject.transform.position - transform.position).normalized;
            enemyRigidbody.AddForce(awayFromPlayer * powerUpforce, ForceMode.Impulse);
        }


    }
    private IEnumerator PowerUpCountDown()
    {
        for(int i = 0; i < powerUPindicators.Length; i++)
        {
            powerUPindicators[i].SetActive(true);
            yield return new WaitForSeconds(2);
            powerUPindicators[i].SetActive(false);

        }
        hasPowerUp = false;
    }
}
