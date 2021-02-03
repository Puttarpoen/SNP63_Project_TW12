using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HandControl : MonoBehaviour
{
    public Text L_Text;
    public GameObject Hand;
    public GameObject Origin;
    public GameObject P;
    public static float I;
    // Start is called before the first frame update
    void Start()
    {
        I = 1f;
    }

    // Update is called once per frame
    void Update()
    {

        L_Text.text = I.ToString("F1");
        //Hand.transform.position = new Vector3(Hand.transform.position.x, Origin.transform.position.y, 0);
    }
    

    public void ISetting(float newI)
    {
        I = newI;
        P.transform.SetParent(null);
        transform.localScale = new Vector3(Hand.transform.localScale.x, I , Hand.transform.localScale.z);
        P.transform.SetParent(transform);

    }
    
}
