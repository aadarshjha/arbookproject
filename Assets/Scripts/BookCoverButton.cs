using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class BookCoverButton : MonoBehaviour
{
    public VirtualButtonBehaviour vb;

    public GameObject summary;
    public GameObject review; 
    
    // Start is called before the first frame update
    void Start()
    {
        vb.RegisterOnButtonPressed(OnButtonPressed); 
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        // toggle the text
        if (summary.activeInHierarchy)
        {
            summary.SetActive(false);
            review.SetActive(true);
        } else {
            summary.SetActive(true);
            review.SetActive(false);
        }
    }
}
