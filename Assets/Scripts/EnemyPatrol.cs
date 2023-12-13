using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    public LevelManager levelManager;
    [SerializeField] private AudioSource dieSoundEffect;
    public GameObject PunktA;
    public GameObject PunktB;
    private Rigidbody2D rb;
    private Animator anim;
    private Transform currentPoint;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        currentPoint = PunktA.transform;
        anim.SetBool("isRunning", true);
        levelManager = FindObjectOfType<LevelManager>();
    }

    
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if(currentPoint == PunktA.transform)
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(speed, 0);
        }

        if(Vector2.Distance(transform.position, currentPoint.position)< 0.5f && currentPoint == PunktA.transform)
        {
            flip();
            currentPoint = PunktB.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == PunktB.transform)
        {
            flip();
            currentPoint = PunktA.transform;
        }
    }

    private void flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Dog")
        {
            dieSoundEffect.Play();
            levelManager.RespawnPlayer();
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(PunktA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(PunktB.transform.position, 0.5f);
        Gizmos.DrawLine(PunktA.transform.position, PunktB.transform.position);
    }
}
