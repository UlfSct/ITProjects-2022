using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShporaController : MonoBehaviour
{
    public GameObject shporaImage;
    public bool isOpen;

    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;   
    }

    public void OpenShpora()
    {
        shporaImage.SetActive(true);
        isOpen = true;
    }

    public void CloseShpora()
    {
        shporaImage.SetActive(false);
        isOpen = false;
    }
}
