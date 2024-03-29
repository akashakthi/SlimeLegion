using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
    public static Skeleton instance;

    public float attackRange;
    public Animator anim;
    public Transform attackPoint;
    private GameObject Hitbox;
    public GameObject panah;
    public float panahSpeed;

    public bool isShootings;

    public LayerMask playerMask;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        //if (AISkeleton.instance.isStun == true)
        //{
        //    return;
        //}

        Shooting();
    }

    void Shooting()
    {
        Collider2D[] detectPlayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerMask);
        foreach (Collider2D Player in detectPlayer)
        {
            anim.SetTrigger("Shoot");
            isShootings = true;
            Debug.Log("ada Player");
        }
    }
    
    public void ShootArrow()
    {
        if (isShootings == true)
        {
            GameObject arrow = Instantiate(panah, attackPoint.transform.position, attackPoint.transform.rotation);
            arrow.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x * panahSpeed, 0);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
