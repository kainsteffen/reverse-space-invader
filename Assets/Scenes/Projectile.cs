using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public string source;
    public float damage;
    public GameObject onDeathEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSource(string source)
    {
        this.source = source;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            collision.collider.GetComponent<Enemy>().TakeDamage(damage);
            Instantiate(onDeathEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
