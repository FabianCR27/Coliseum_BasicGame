using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float damage =25 ;
    public float enemy_damage = 10;
    
    void Start()
    {

    }
    private void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {

            if (other.gameObject.tag == ("Enemy"))
            {
                other.gameObject.GetComponent<Health_Bar>().TakeDamage(damage);

            }

            if (other.gameObject.tag == ("DummyPlayer"))
            {

            other.gameObject.GetComponent<Health_Bar>().PlayerTakeDamage(enemy_damage);

            }


    }

}
