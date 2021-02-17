using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellOpen : MonoBehaviour
{
    public GameObject textTutorial;
    private void Start()
    {
        GetComponent<Animator>();

    }
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Animator>().SetInteger("Open", 1);
        textTutorial.SetActive(false);
    }
}
