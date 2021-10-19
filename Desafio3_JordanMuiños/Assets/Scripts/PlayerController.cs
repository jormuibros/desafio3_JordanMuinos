using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerLives; //la vida actual del jugador
    public Vector3 playerDirection; //direccion
    public int itemHealer; //sanacion
    public int enemyDamage; //da�o
    public int playerHearts; //variable de corazones para sumar
    public int playerDeshearted; //variable de corazones para restar
    public float speed; //velocidad
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(playerDirection);
        //Hearts();
        Heal();
        Damage();
        Debug.Log(playerHearts + " Corazones le quedan al jugador");
        Debug.Assert(playerLives > 0, "El jugador esta vivo");
        Debug.Assert(playerLives < 0, "El jugador esta muerto");
        //if (playerLives > 0)
        //{
        //    Debug.Log("Jugador esta vivo");
        //}
        //else
        //{
        //    Debug.Log("Jugador esta muerto");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    void movement()
    {
        transform.Translate(playerDirection * speed *  Time.deltaTime);
       
    }

    //void Hearts()
    //{
      //  playerLives = playerLives + itemHealer - enemyDamage;
    //}

    void Heal()
    {
        playerLives = playerLives + itemHealer;
    }

    void Damage()
    {
        playerLives = playerLives - enemyDamage;
    }
}
