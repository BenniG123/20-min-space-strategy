using UnityEngine;
using System.Collections;

public class ShipAttributes : MonoBehaviour {

    public int health;
    public int maxHealth;
    public bool isSelected;
    public int teamIndex;
    public int armor;
    public GameObject deathParticles;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            health -= damage;

            if (health < 1)
            {
                Die();
            }
        }
    }

    public void Heal(int healAmount)
    {
        if (healAmount > 0)
        {
            health += healAmount;

            if ( health > maxHealth)
            {
                health = maxHealth;
            }
        }
    }

    public void Die()
    {
        Instantiate(deathParticles, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
