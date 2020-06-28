using UnityEngine;

public class EnemyDmg : MonoBehaviour
{

    //floats für Health und max health
    public float Health;
    public float maxHealth;
    //-------------------------------------


    // Helath und maxHealth gleichgesetzt zum start
    void Start()
    {
        Health = maxHealth;
    }
    // Funktion für DealDmg als float
        //tot checken jede sek wäre waste, daher bei jedem hit.


    public void DealDamage(float damage)
    {
        Health -= damage;
        CheckDeath();
    }
    //-------------------------------------


    //checkt ob der charakter overheald
        // wenn ja setzte health auf max health
    private void CheckOverheal()

    {
        if(Health < maxHealth)
        {
            Health = maxHealth;

             
        }


    }
    //-------------------------------------


    //checkt death defnition
    //wenn health kleiner gleich 0 dann kill
    private void CheckDeath()
    {
        if (Health <= 0)

        {

            Destroy(gameObject);
        }


    }


}
