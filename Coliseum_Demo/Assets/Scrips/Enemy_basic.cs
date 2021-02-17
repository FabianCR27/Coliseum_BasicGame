using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_basic : MonoBehaviour
{

    public Transform target ;
    public int aware_distance = 10;
    Health_Bar alive;
    public BoxCollider weapon;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>();
        target = GameObject.FindWithTag("DummyPlayer").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Animator>().GetBool("isAttacking") == true)
        {
            weapon.enabled = true;
        }
        if (GetComponent<Animator>().GetBool("isAttacking") == false)
        {
            weapon.enabled = false;
        }





        Vector3 direction = target.position - this.transform.position;
            float angle = Vector3.Angle(direction, this.transform.forward);
            transform.LookAt(target);
            if (Vector3.Distance(target.position, this.transform.position) < aware_distance && angle < 180)
            {
                //Vector3 direction = target.position - this.transform.position;
                direction.y = 0;
                this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

                GetComponent<Animator>().SetBool("isIdle", false);

                if (direction.magnitude > 0.5)
                {
                    this.transform.Translate(0, 0, 0.0001f);
                     GetComponent<Animator>().SetBool("isWalking", true);
                     GetComponent<Animator>().SetBool("isAttacking", false);
                }
                else
                {
                    GetComponent<Animator>().SetBool("isAttacking", true);
                    GetComponent<Animator>().SetBool("isWalking", false);
                }


            }
            else
            {
                 GetComponent<Animator>().SetBool("isIdle", true);
                 GetComponent<Animator>().SetBool("isAttacking", false);
                 GetComponent<Animator>().SetBool("isWalking", false);
            }
        
    }

    
}
