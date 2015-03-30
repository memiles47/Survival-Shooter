using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    // Declaration of Public variables
    public PlayerHealth playerHealth;
    //public float restartDelay = 5.0f;

    // Declaration of Priviate variables
    private Animator anim;
    //private float restartTimer;


    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");
            //restartTimer += Time.deltaTime;

            //if(restartTimer >= restartDelay)
            //{
            //    Application.LoadLevel(Application.loadedLevel);
            //} 
        }
    }
}
