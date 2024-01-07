using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PindahScene : MonoBehaviour
{
    public void scene(string scene)
    {
        Application.LoadLevel(scene);
    }
}