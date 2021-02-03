using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSlide : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //    if (Input.GetKey(KeyCode.LeftArrow)&&transform.position.x>=-13.4f&&FollowBullet.shooting==false)
        //    {
        //        transform.Translate(Vector3.right * -1 *5* Time.deltaTime);
        //    }

        //    if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 0f && FollowBullet.shooting == false)
        //    {
        //        transform.Translate(Vector3.right *5* Time.deltaTime);
        //    }
        if(transform.position.x>0)
        {
            transform.position = new Vector3(0f, 0, -10f);
        }
        
    }
    
    public void Left()
    {

        if (transform.position.x > -13.4f && FollowBullet.shooting == false)
        {
            StartCoroutine(ExampleCoroutine());
        }
    }
    public void LeftEnd()
    {
        StopAllCoroutines();
    }
    public void Right()
    {
        if (transform.position.x < 0f && FollowBullet.shooting == false)
        {
            StartCoroutine(Rightslide());
        }
    }
    public void RightEnd()
    {
        StopAllCoroutines();
    }
    IEnumerator ExampleCoroutine()
    {

        for (; transform.position.x > -13.4f;)
        {
            transform.Translate(Vector3.right * -1 * 5 * Time.fixedDeltaTime);
            yield return new WaitForSecondsRealtime(0.0025f);
        }

    }   

        
    IEnumerator Rightslide()
    {
        for (; transform.position.x < 0f;)
        {
            transform.Translate(Vector3.right * 5* Time.fixedDeltaTime);
            yield return new WaitForSecondsRealtime(0.0025f);
        }
    }

}
