using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerDamage : MonoBehaviour
{
    public PlayerHealthNew playerHealth;
    public float pdamage;
    public float Heal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy Green") | other.gameObject.CompareTag("Enemy Orange"))
        {
            playerHealth.health -= pdamage;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Medkit"))
        {
            Destroy(other.gameObject);
            playerHealth.health += Heal;

        }
        
    }
}
