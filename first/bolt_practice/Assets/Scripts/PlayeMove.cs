using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float playerSpeed = 0.1f;

    [SerializeField]
    private float playerJumpforce = 0.1f;

    [SerializeField]
    private GameObject bulletObj = null;

    [SerializeField]
    private GameObject instantiateObj = null;

    private bool jump = false;

  

    // Update is called once per frame
    private void Update()
    {
        Move(); 

        if (Input.GetButtonDown("Jump"))
        {
            PlayerJump();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }

    }
    private void Move()

    private void PlayerJump()
    {
        GetComponent<Animator>().SetBool("Walk", false);
        GetComponent<Animator>().SetBool("Jump", true);

        Vector2 vector2 = new Vector2(0, playerJumpforce);
        jump = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Platform")
        {
            GetComponent<Animator>().SetBool("Jump", false);
            jump = false;
        }
    }

    private void Fire()
    {
        float direction = transform.localScale.x;
        Quaternion quaternion = new Quaternion(0, 0, 0, 0);
        Instantiate(bulletObj, instantiateObj.transform.position, quaternion) GetComponent<Bullet>().InstantiateBullet(direction);
    }
}
