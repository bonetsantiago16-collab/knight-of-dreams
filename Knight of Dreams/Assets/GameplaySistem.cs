using UnityEngine;

public class GameplaySistem : MonoBehaviour
{
    [Header("player statistics")]

    [SerializeField] private string Name;

    [SerializeField][Range(0, 100)] private int Health;

    [SerializeField][Range(0, 25)] private int Damage;

    [SerializeField] private int EnemyBossArmor = 10;
    

    [Header("Inventory")]

    [SerializeField][Range(0, 6)] private int Consumables;

    [SerializeField][Range(0, 10)] private int Keys;

    [SerializeField][Range(0, 100000)] private int Gems;
    void Start()
    {
        Debug.Log("Welcome player " + Name);


        CheckHealth();
        KeyCounter();
        DamageControl();

    }

   
    private void CheckHealth()
    {
        if (Health == 100)
        {
            Debug.Log("Stable Health");
        }
        else if(Health >= 50)
        {
            Debug.Log("Declining health");
        }
        else if(Health < 50)
        {
            Debug.LogWarning("Low Health");
        }
    }
    private void KeyCounter()
    {
        if (Keys >= 1 || Keys <= 10)
        {
            Debug.Log("Keys available");
        }
        else if(Keys == 0)
        {
            Debug.Log("No Keys");
        }
        else if(Keys > 0)
        {
            Debug.LogError("Counter error");
        }
    }
    private void DamageControl()
    {
        if (Damage < 10)
        {
            Debug.LogWarning("insufficient damage");
        }
        else if (Damage > 10)
        {
            Debug.Log("beneficial harm");
        }
    }
}
