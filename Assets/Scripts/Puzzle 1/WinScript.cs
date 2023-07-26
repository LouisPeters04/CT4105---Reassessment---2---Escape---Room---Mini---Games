using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    public GameObject MyObjects;

    // Start is called before the first frame update
    void Start()
    {
        pointsToWin = MyObjects.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentPoints >= pointsToWin)
        {
            //win
            transform.GetChild(0).gameObject.SetActive(true);

        }
    }

    public void AddPoints()
    {
        currentPoints++;
    }

}
