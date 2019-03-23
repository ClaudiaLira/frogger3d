using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    private Rigidbody rb;
    GameObject gameManager;
    private bool isJumping = false;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            this.isJumping = true;
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }

        Vector3 movement = new Vector3(moveHorizontal * speed, rb.velocity.y, moveVertical * speed);

        rb.velocity = movement;

        if (transform.position.y < -10 || transform.position.x > 20 || transform.position.x < -20)
        {
            gameManager.GetComponent<GameManager>().SpawnPlayer();
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        isJumping = false;
        if (col.gameObject.tag == "Finish")
        {
            gameManager.GetComponent<GameManager>().Finish();
        }
    }

}
