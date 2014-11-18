using UnityEngine;
using System.Collections;

public class Player : Entity
{

    public delegate void PlayerAction();
    public static event PlayerAction HpChange;

    public delegate void PlayerDeath();
    public static event PlayerDeath Dead;

    public string name;
    public float maxhp = 1;

	// Use this for initialization
	public override void Awake()
	{
	    Name = name;
	    MaxHealth = maxhp;

        base.Awake();

	}

    public override void Hit(float damage)
    {
        base.Hit(damage);
        if (HpChange != null)
            HpChange();
    }

    public override void Death()
    {
        if (Dead != null)
            Dead();
        base.Death();

    }

    public void OnCollisionStay2D(Collision2D otherCollider)
    {
        Zombie zombie = otherCollider.gameObject.GetComponent<Zombie>();
        if (zombie != null)
        {
            
            Hit(zombie.damage);
        }

        //base.OnTriggerEnter2D(otherCollider);
    }

}
