using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PinCode:MonoBehaviour
{
    [SerializeField]
     private string key="6122";
    private string currPin=string.Empty;
    public Text screenText;
    private bool isOn;
    private Animator animator;
    [SerializeField] private GameObject statusButton;
    
    public void Start()
    {
        this.screenText.text = "Error";
        animator = statusButton.GetComponent<Animator>();
    }
    public void Update()
    {
        animator.SetBool("isWorking", isOn);
        if (!isOn)
        {
            OnClearKeyPressed();
            return;
        }
        this.screenText.text=this.currPin;
    }
    public void On1KeyPressed()
    {
        if(this.currPin.Length<4) this.currPin+="1";
    }
    public void On2KeyPressed()
    {
        if(this.currPin.Length<4) this.currPin+="2";
    }
    public void On3KeyPressed()
    {
        if(this.currPin.Length<4) this.currPin+="3";
    }
    public void On4KeyPressed()
    {
        if(this.currPin.Length<4) this.currPin+="4";
    }
    public void On5KeyPressed()
    {
        if(this.currPin.Length<4) this.currPin+="5";
    }
    public void On6KeyPressed()
    {
        if(this.currPin.Length<4) this.currPin+="6";
    }
    public void On7KeyPressed()
    {
        if(this.currPin.Length<4) this.currPin+="7";
    }
    public void On8KeyPressed()
    {
        if(this.currPin.Length<4) this.currPin+="8";
    }
    public void On9KeyPressed()
    {
        if(this.currPin.Length<4) this.currPin+="9";
    }
    public void On0KeyPressed()
    {
        if(this.currPin.Length<4) this.currPin+="0";
    }
    public void OnEnterKeyPressed()
    {
        if(this.currPin.Equals(key))
        {
            print("Ok");
        }
        else
        {
            print("not ok");
        }
    }
    public void OnClearKeyPressed()
    {
        this.currPin=string.Empty;
    }
}
