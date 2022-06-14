using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SetttingMenu : MonoBehaviour
{
    //drag and drop Text here
    [SerializeField] Text mytext;
    [SerializeField] TMP_Text mode_text;
    [SerializeField] TMP_Text level_text;
    [SerializeField] Slider myslider;

    // Start is called before the first frame update
    void Start()
    {
        myslider.minValue = 0; 
        myslider.maxValue = 5;
        myslider.wholeNumbers = true;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleButtonClick(Toggle t){
        if(t.isOn) mytext.text = "Active";
        if(!t.isOn) mytext.text = "Inactive";
    }

    //Add this method to your dropdown
    // drag and drop TMP_dropdown into this method
    public void dropDownValue(TMP_Dropdown dropdown){
         Debug.Log(dropdown.options[dropdown.value].text);
         Debug.Log(mode_text);
    }


    public void dropDownListener(int i){
         Debug.Log("i"+i);
    }


    public void sliderListener(){
        level_text.text= "Level: "+myslider.value + "";
    }



}
