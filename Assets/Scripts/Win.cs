using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {

    public delegate void Winning();
    public static event Winning Weiner;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnCollisionStay2D(Collision2D otherCollider)
    {
        Player player = otherCollider.gameObject.GetComponent<Player>();
        if (player != null)
        {
            if (Weiner != null)
                Weiner();
        }

        //base.OnTriggerEnter2D(otherCollider);
    }
}
