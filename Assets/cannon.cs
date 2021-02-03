using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cannon : MonoBehaviour
{
    public static bool canRot;
    FollowBullet follow = new FollowBullet();
    Timer timee = new Timer();
    public AudioSource SoundCannon;
    public GameObject ball;
    public float launchForce;
    public Transform shotPoint; 
    public Text angel_Text; //โชว์ค่า องศาของปืน
    public Text Force_Text; //โชว์ค่า ความเร็วเริ่มต้น
    public Text ammo_Text; //โชว์คะแนน
    public Text Forcex;
    public Text sin;
    public Text cos;
    public Text S;
    public GameObject boombPos;
    public GameObject boomb;
    public int ammo;

    public GameObject point;
    GameObject[] points;
    public int numberOfPoint;
    public float spaceBetweenPoints;
    Vector2 direction;

    

    private void Start()
    {
        
        points = new GameObject[numberOfPoint];
        for (int i = 0; i<numberOfPoint; i++)
        {
            points[i] = Instantiate(point, shotPoint.position, Quaternion.identity); // โชว์เส้นไกด์ระยะในการยิ่ง
        }


    }
    void Update()
    {
        Vector2 cannonPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    

        //if (180 - transform.rotation.eulerAngles.z < 0)
        //{
        //    transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
        //}
        //else if (180 - transform.rotation.eulerAngles.z > 90)
        //{
        //    transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
        //}

        if (FollowBullet.shooting == false && Timer.stopTimer == false&&canRot==true)
        {
            direction = mousePosition - cannonPosition;
            transform.right = direction;
        }
        
        /*if (Input.GetMouseButtonDown(0)&&ammo>0&&FollowBullet.shooting==false && Timer.stopTimer == false && (Camera.main.ScreenToViewportPoint(Input.mousePosition).x<0.85f&& Camera.main.ScreenToViewportPoint(Input.mousePosition).y>0.3f)&&Time.timeScale==1)
        {
            if (canRot == false)
            {
                FollowBullet.shooting = true;
                SoundCannon.Play();
                Shoot();
                ammo--;
            }
                
        }*/
        for (int i = 0; i<numberOfPoint; i++)
        {
            points[i].transform.position = PointPosition(i * spaceBetweenPoints);
        }

        int tem_angless = (int)Mathf.Abs(180 - transform.rotation.eulerAngles.z);
        float angless = tem_angless * Mathf.PI / 180;

        angel_Text.text = tem_angless.ToString();
          //(180 - transform.rotation.eulerAngles.z).ToString("F2");

        sin.text = tem_angless.ToString();
        cos.text = tem_angless.ToString();


        Forcex.text = launchForce.ToString("f0");
        //Forcex.text = (launchForce * launchForce).ToString("f2");
        Force_Text.text = launchForce.ToString("F2");
        ammo_Text.text = ammo.ToString("F0");

        //float m = Mathf.Abs(Mathf.Cos(180f - transform.rotation.eulerAngles.z));
        //Debug.Log(launchForce);
        float m = 2* launchForce * launchForce * Mathf.Sin(angless)* Mathf.Cos(angless)/10;
        S.text = m.ToString();


    }
    void Shoot()
    {
        
        
            GameObject newBall = Instantiate(ball, shotPoint.position, shotPoint.rotation);
            newBall.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
            GameObject newG =Instantiate(boomb, new Vector2(boombPos.transform.position.x, boombPos.transform.position.y), Quaternion.identity);
            Destroy(newG, 2);
            Destroy(newBall, 2);
        
        
    }
    Vector2 PointPosition(float t)
    {
        Vector2 position = (Vector2)shotPoint.position + (direction.normalized * launchForce * t) + 0.5f * Physics2D.gravity * (t * t);
        return position;
    }

    public void ForceSetting(float newForce)
    {
        launchForce = newForce; // เป็นค่าความเร็วเริ่มต้นที่กำหนดไว้ในหน้า unity โดยจะกำหนดค่าเริ่มต้นที่ 1 m/s 
    }

    public void Fire()
    {
        if (ammo > 0 && FollowBullet.shooting == false && Timer.stopTimer == false && Time.timeScale == 1)
        {
            if (canRot == false)
            {
                FollowBullet.shooting = true;
                SoundCannon.Play();
                Shoot();
                ammo--;
            }

        }
    }
    
}
