using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : Enemy
{
    public GameObject target;
    public float speed;
    public float turnSpeed;
    public float attackCooldown;
    public GameObject projectile;

    private float attackTimer;

    private Rigidbody2D rb;

	// Use this for initialization
	public override void Start ()
    {
		base.Start();

        target = GameController.Instance.player;
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	public override void FixedUpdate ()
    {
		base.FixedUpdate();

        attackTimer -= Time.deltaTime;
        if(attackTimer < 0)
        {
            int[] angles = {0, 90, 180, 270};
            Random rand = new Random();
            GameObject proj = Instantiate(projectile, transform.position, Quaternion.Euler(0, 0, angles[Random.Range(0,3)]));
            proj.GetComponent<Rigidbody2D>().AddForce(proj.transform.up * 5, ForceMode2D.Impulse);
            attackTimer = attackCooldown;
        }
	}
}
