using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class panel : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    // Start is called before the first frame update
    void Start()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void button()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }

    public void back()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
    }
}
