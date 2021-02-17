using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class Health_Bar : MonoBehaviour
{
    public Image healthBar;
    public float max_health = 100f;
    public float cur_health;
    public bool alive = true;

    [SerializeField] private string preTextScore = "Score: 00";
    [SerializeField] private Text Scoretext = null;
    public Image healthBar_player;
    public float max_health_player = 500f;
    public float cur_health_player;
    public bool alive_player = true;
    PauseGame gameover;
    int score = 00;
    private void Start()
    {
        gameover = GetComponent<PauseGame>();
        alive = true;
        cur_health = max_health;
        cur_health_player = max_health_player;
        alive_player = true;
        SetHealthBar();
        SetHealthBarPlayer();
        //AddPoints();
        
        
        
    }
    public void TakeDamage(float amount)
    {
        if (tag == "Enemy")
        {
            if (!alive)
            {               
                // return;
            }
            if (cur_health <= 0)
            {

                Destroy(gameObject);
              
                  //  AddPoints();
                            
                alive = false;
                cur_health = 0;
            }
            cur_health -= amount;
            SetHealthBar();
        }


    }


    public void PlayerTakeDamage(float amount)
    {
        if (tag == "DummyPlayer")
        {
            if (!alive_player)
            {
                // return;
            }
            if (cur_health_player <= 0)
            {
                //animation death

                alive_player = false;
                gameover.gameOver();
            }
            cur_health_player -= amount;
            SetHealthBarPlayer();
        }
    }

    public void SetHealthBar()
    {
        float my_health = cur_health / max_health;
        healthBar.transform.localScale = new Vector3(Mathf.Clamp(my_health, 0f, 1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
    public void SetHealthBarPlayer()
    {
        float my_health_player = cur_health_player / max_health_player;
        healthBar_player.transform.localScale = new Vector3(Mathf.Clamp(my_health_player, 0f, 1f), healthBar_player.transform.localScale.y, healthBar_player.transform.localScale.z);
    }



  //  public void AddPoints()
    //{

     //   score += 10;
       // Scoretext.text = preTextScore + score.ToString("00");
////
    //}
}

