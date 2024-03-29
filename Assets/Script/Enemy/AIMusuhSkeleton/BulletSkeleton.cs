using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSkeleton : MonoBehaviour
{
    //private GameObject player;
    //private Rigidbody2D rb;

    public float DamagingPlayer;
    public bool flip;
    private SpriteRenderer sprite;

    //public float force;
    //public float waktu;

    //public GameObject destrotEffect;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        //player = GameObject.FindGameObjectWithTag("Player");
        //Vector3 direction = player.transform.position - transform.position;
        //rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

        //float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0, 0, rot + -180);

    }

    // Update is called once per frame
    void Update()
    {
        //waktu += Time.deltaTime;
        //if (waktu > 10)
        //{
        //Destroy(gameObject);
        //}
        Flip();
        sprite = GetComponent<SpriteRenderer>();
    }
    //public Transform playerPos;

    void Flip()
    {
        Vector2 scale = transform.localScale;
        if (SlimeMovement.instance.transform.position.x <= transform.position.x)
        {
            sprite.flipX = false;
        }
        else if (SlimeMovement.instance.transform.position.x >= transform.position.x)
        {
            sprite.flipX = true;
        }
        transform.localScale = scale;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && PlayerStatus.instance.playerHealth > 0)
        {
            PlayerStatus.instance.HealthBar(DamagingPlayer);
            Destroy(this.gameObject);
        }
        if (collision.gameObject)
        {
            Destroy(gameObject);
        }
    }
}
