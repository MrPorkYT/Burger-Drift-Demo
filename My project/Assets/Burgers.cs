using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Burgers : MonoBehaviour
{
    public int points = 0;
    public Text counterText;
    public float counter;

    public void Update()
    {
        counterText.text = points.ToString();
    }
}
