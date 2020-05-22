using System.Collections;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    [SerializeField]
    private float moveSpeed = 1.5f;
    [SerializeField]
    private float jumpDelay = 0.05f;
    private bool jumpReady = true;

    void Awake()
    {
        playerRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(jumpReady)
        {
            MovePlayer();
            jumpReady = false;
        }
        else
        {
            StartCoroutine("JumpTime");
        }
    }

    void MovePlayer()
    {
        if (Input.GetKeyUp("space"))
        {
            playerRigidbody.velocity = new Vector2(0.0f, moveSpeed);
        }
    }

    IEnumerator JumpTime()
    {
        jumpReady = true;
        yield return new WaitForSeconds(jumpDelay);
    }
}
