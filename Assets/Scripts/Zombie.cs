using System.Reflection;
using UnityEngine;
using System.Collections;

public class Zombie : Entity
{
    public delegate void ZombieDeath();
    public static event ZombieDeath Dead;


    public string name;
    public float maxhp = 1;
    public float damage = 1;
	// Use this for initialization


    void OnEnable()
    {
        Player.Dead += Death;
    }

    void OnDisable()
    {
        Player.Dead -= Death;
    }

    public override void Awake()
    {
      
        Name = name;
        MaxHealth = maxhp;

        base.Awake();

    }

    public override void Death()
    {
        if (Dead != null)
            Dead();

        base.Death();
    }

    public void OnTriggerEnter2D(Collider2D otherCollider)
    {

    }

    public override void Update()
    {
        base.Update();
    }
}
