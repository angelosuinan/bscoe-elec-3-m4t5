using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {
    public GameObject explosion;

    ScoreBoard scoreBoard;
    [SerializeField] int score = 12;
    [SerializeField] int hp = 3;
    // Use this for initialization
    void Start () {
        AddBoxCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }
    private void AddBoxCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }
    // Update is called once per frame
    void Update () {
		
	}
    void OnParticleCollision(GameObject other)
    {
        if (hp == 0)
        {
            GameObject newExplosion = Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
            scoreBoard.ScoreHit(score);
           
        }
        hp = hp - 1;

    }
}
