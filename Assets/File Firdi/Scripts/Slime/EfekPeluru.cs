using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfekPeluru : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Stuned");
            Destroy(gameObject);
        }
        if (collision.gameObject)
        {
            Destroy(gameObject);
        }
    }
}
