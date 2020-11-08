using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody playerRb;
    public float speed;
    private float forwardInput;
    public bool hasPowerUp;
    private GameObject focalPoint;
    private float powerUpStrength = 15.0f;
    public GameObject powerUpIndicator;
    private ScoreManager scoreManagerScript;

    void Start()
    {
        scoreManagerScript = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.FindGameObjectWithTag("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
        {
            scoreManagerScript.loss = true;
        }
            forwardInput = Input.GetAxis("Vertical");

        powerUpIndicator.transform.position = transform.position + new Vector3(0, -.05f, 0);


    }
    private void FixedUpdate()
    {
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerUpCountdown());
            powerUpIndicator.gameObject.SetActive(true);
        }
    }

    IEnumerator PowerUpCountdown()
    {
        yield return new WaitForSeconds(7);
        hasPowerUp = false;
        powerUpIndicator.gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Enemy") && hasPowerUp == true)
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position).normalized;

            enemyRigidbody.AddForce(awayFromPlayer * powerUpStrength, ForceMode.Impulse);
        }
    }
}
