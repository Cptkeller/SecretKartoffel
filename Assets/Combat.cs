using UnityEngine;

public class Combat : MonoBehaviour
{
    //animator für animation
    //Transform als referez für Attack und Player Pos
    // Attack floats: range und attack dmg
    //AoeAttack floats: Aoerange und Aoe DMG

    public Animator animator;
    public Transform PlayerPos;
    public Transform attackPoint;
    public Transform AoeRange;
    public LayerMask enemyLayers;
    public float range = 0.5f;
    public float attackDamage = 40f;
   
 
        Vector2 sett;
    
    //-------------------------------------

        //Update void für check per frame 
        //If question für Attack
        //If question für AoeAttack


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Attack();
        }
        
        

        
        //-------------------------------------
       

        //Definiton für attack
        void Attack()
        {
            animator.SetTrigger("kick");
           Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, range, enemyLayers);

            foreach (Collider2D enemy in hitEnemies)
            {
                //enemy.GetComponent<EnemyDmg>().DealDamage(attackDamage);
            }
    }

        //-------------------------------------

        //Definiton für AoeAttack
        

    }
         //-------------------------------------



        //range indicator für Attack point und Player pos.
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        
        Gizmos.DrawWireSphere(attackPoint.position, range);
        Gizmos.DrawWireCube(PlayerPos.position, new Vector2( 1, 0 ));
    }

        //-------------------------------------
}
