using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float velocityMovement = 5.0f;
    public float velocityRotation = 200.0f;
    public float currentHealth = 100;
    public float maxHealth = 100;
    private Animator anim;
    public float x, y;
    public EnemyController enemyController;
    public CanvasManager canvasManager;
    public float enemyDMG = 8;
    public float lifeIncrease = 8;
    public float points = 0;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocityRotation, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocityMovement);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
        }
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Slash");
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            currentHealth -= enemyDMG;
        }
        if (other.gameObject.tag == "coin")
        {
            if (currentHealth == 100)
            {
                return;
            }
            else
            {
                currentHealth += enemyDMG;
                Destroy(other.gameObject);
            }
        }
    }
}