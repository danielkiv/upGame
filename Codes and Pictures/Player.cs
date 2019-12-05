//player script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [System.Serializable]

    //holding player stats
    public class PlayerStats
    {
        public int MaxHealth = 100;

        private int CurrentHealth;

        //current player health
        public int CurrHealth
        {
            get
            {
                return CurrentHealth;
            }
            set
            {
                CurrentHealth = Mathf.Clamp(value, 0, MaxHealth);
            }
        }

        public void Init()
        {
            CurrentHealth = MaxHealth;
        }

    }

    public PlayerStats stats = new PlayerStats();
    public int fallBoundary = -20;
    [SerializeField] private StatusIndicator status;

    void Start()
    {
        stats.Init();
        if (status == null)
        {
            Debug.LogError("Player need status reference");
        }
        else
        {
            status.setHealth(stats.CurrHealth, stats.MaxHealth);
        }
    }

    //if the player fall below a boundary, this will kill the player
    void Update ()
    {
        if (transform.position.y <= fallBoundary)
        {
            DamageHealth(9999999);
        }
    }

    //damage the player health
    public void DamageHealth (int damage)
    {
        stats.CurrHealth -= damage;

        if(stats.CurrHealth <= 0)
        {
            GameMaster.KillPlayer(this);
        }

        status.setHealth(stats.CurrHealth, stats.MaxHealth);
    }

    //heal player
    public void GainHealth (int healthGain)
    {
        stats.CurrHealth += healthGain;

        if(stats.CurrHealth >= stats.MaxHealth)
        {
            stats.CurrHealth = stats.MaxHealth;
        }

        status.setHealth(stats.CurrHealth, stats.MaxHealth);
    }

}
