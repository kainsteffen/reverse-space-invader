using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float boundMargin;
    public GameObject projetile;
    public float projectileSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.Translate(new Vector3(Time.deltaTime * -speed, 0, 0), Space.Self);
            RaycastHit2D leftHit = Physics2D.Raycast(transform.position, Vector3.Cross(transform.forward, transform.up), boundMargin);
            if (leftHit.collider != null)
            {
                transform.Rotate(0, 0, -90);
            }
        }
        else if (Input.GetKey("d"))
        {
            transform.Translate(new Vector3(Time.deltaTime * speed, 0, 0), Space.Self);
            RaycastHit2D rightHit = Physics2D.Raycast(transform.position, -Vector3.Cross(transform.forward, transform.up), boundMargin);
            if (rightHit.collider != null)
            {
                transform.Rotate(0, 0, 90);
            }
        }

        if(Input.GetKeyDown("space"))
        {
            GameObject proj = Instantiate(projetile, transform.position, transform.rotation);
            proj.GetComponent<Rigidbody2D>().AddForce(proj.transform.up * projectileSpeed, ForceMode2D.Impulse);
            proj.GetComponent<Projectile>().SetSource("Player");
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    { }
}
