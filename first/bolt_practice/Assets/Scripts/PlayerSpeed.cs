using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpeed : MonoBehaviour
{

    public float plyerSpeed = 3f;

    // Start is called before the first frame update
    private void Update()
    {
        Move();
    }
    
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        Vector3 vector3 = new Vector3();
        float moveSpeed = h + plyerSpeed + Time.deltaTime;
        vector3.x = moveSpeed;

        transform.Translate(vector3);

        if (h < 0)
        {
            this.GetComponent<Animator>().SetBool("Walk", true);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (h == 0)
        {
            this.GetComponent<Animator>().SetBool("walk", false);
        }
        else
        {
            this.GetComponent<Animator>().SetBool("walk", true);
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
   
}
