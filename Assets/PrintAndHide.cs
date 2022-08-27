using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public int i = 3;
    public Renderer rend;
    public int ranNum;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;

        if (gameObject.tag == "Blue")
        {

            ranNum = Random.Range(200, 251);
        }
        //Debug.Log(ranNum + gameObject.tag);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + ++i);

        if (i == 101 
            && gameObject.tag == "Red")
        {
                gameObject.SetActive(false);
        }

        if (gameObject.tag == "Blue"
            && i == ranNum)
        {
            rend.enabled = false;
        }

    }
}
