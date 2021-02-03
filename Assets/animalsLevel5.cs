using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalsLevel5 : MonoBehaviour
{
    public int ani_score;
    public GameObject blood;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "han")
        {
            ScoreManager.total_score += ani_score;
            spawn(blood);
            Destroy(gameObject);
        }
    }
    void spawn(GameObject m)
    {
        //StartCoroutine(Wait());

        GameObject newm = Instantiate(m, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        
            Destroy(newm, 2);


    }
}
