using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Michsky.UI.ModernUIPack;

public class ColorChange : MonoBehaviour
{
    public GameObject Cell;
    public Material BloodMaterial;
    public Slider ColorSlider;
    public float Red;
    public float Green;
    public float Blue; 
    // Start is called before the first frame update
    void Start()
    {
        ChangeColor();

    }

    //Gets called from ColorSlider when slider changes and changes blood cell color
    public void ChangeColor ()
    {
        Red = 255 * ColorSlider.value;
        Blue = 255 - (255 * ColorSlider.value);
        BloodMaterial.color = new Color(Red, Green, Blue);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
