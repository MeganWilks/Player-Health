using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthNew : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image HealthBar;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
        
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.fillAmount = Mathf.Clamp(health / maxHealth , 0, 1);
        
    }

    void Die()
    {
        if (health <= 0 )
        {
            Destroy(gameObject);
            Application.Quit();
            

        }
    }
}
