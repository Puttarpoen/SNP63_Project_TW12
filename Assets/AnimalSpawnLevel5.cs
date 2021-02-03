using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawnLevel5 : MonoBehaviour
{
    public float delayTime;
    int mmm;
    public int a;
    float timee = 0;
    public GameObject[] Animals;
    public GameObject[] SpawnPoit;
    static float[] timer;
     
    // Start is called before the first frame update
    void Start()
    {
        timer = new float[8];
        for (int i = 0; i < timer.Length; i++)
        {
            timer[i] = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        timee += Time.deltaTime;
        if (timee >= delayTime)
        {
            mmm = Random.Range(0, 9);
            if (mmm == 0&&timer[mmm]==0)
            {
                a = Random.Range(0, Animals.Length);
                spawn(Animals[a], SpawnPoit[mmm]);
                timer[mmm]++;
            }
            else if (mmm == 1 && timer[mmm] == 0)
            {
                a = Random.Range(0, Animals.Length);
                spawn(Animals[a], SpawnPoit[mmm]);
                timer[mmm]++;
            }
            else if (mmm == 2 && timer[mmm] == 0)
            {
                a = Random.Range(0, Animals.Length);
                spawn(Animals[a], SpawnPoit[mmm]);
                timer[mmm]++;
            }
            else if (mmm == 3 && timer[mmm] == 0)
            {
                a = Random.Range(0, Animals.Length);
                spawn(Animals[a], SpawnPoit[mmm]);
                timer[mmm]++;
            }
            else if (mmm == 4 && timer[mmm] == 0)
            {
                a = Random.Range(0, Animals.Length);
                spawn(Animals[a], SpawnPoit[mmm]);
                timer[mmm]++;
            }
            else if (mmm == 5 && timer[mmm] == 0)
            {
                a = Random.Range(0, Animals.Length);
                spawn(Animals[a], SpawnPoit[mmm]);
                timer[mmm]++;
            }
            else if (mmm == 6 && timer[mmm] == 0)
            {
                a = Random.Range(0, Animals.Length);
                spawn(Animals[a], SpawnPoit[mmm]);
                timer[mmm]++;
            }
            else if (mmm == 7 && timer[mmm] == 0)
            {
                a = Random.Range(0, Animals.Length);
                spawn(Animals[a], SpawnPoit[mmm]);
                timer[mmm]++;
            }

            //spawn2(mmm);
            timee = 0;
            //delayTime = Random.Range(2, 8);
        }
        for (int i = 0; i < timer.Length; i++)
        {
            if (timer[i]>0)
            {
                timer[i] += Time.deltaTime;
            }
            if(timer[i]>=5f)
            {
                timer[i] = 0;
            }
        }

    }
    void spawn(GameObject m,GameObject point)
    {
        //StartCoroutine(Wait());

        GameObject newm = Instantiate(m, new Vector2(point.transform.position.x, point.transform.position.y), Quaternion.identity);
        Destroy(newm, 5f);
        Debug.Log("Started Coroutine at timestamp : " + Time.time);


    }
}
