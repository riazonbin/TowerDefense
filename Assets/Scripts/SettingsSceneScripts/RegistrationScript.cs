using Assets.Data;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RegistrationScript : MonoBehaviour
{
    [SerializeField]
    Animator registrationAnimator;

    [SerializeField]
    Text firstnameText;

    [SerializeField]
    Text lastnameText;

    [SerializeField]
    Text email;

    [SerializeField]
    Text password;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RegistrateUser()
    {
        if (firstnameText.text != "" && lastnameText.text != "" && email.text != "" && password.text != "") 
        {
            User user = new User()
            {
                Email= email.text,
                Firstname= firstnameText.text,
                Lastname= lastnameText.text,
                Password= password.text
            };

            PlayerPrefs.SetString("PlayerData", JsonConvert.SerializeObject(user));

            registrationAnimator.SetTrigger("RegistrationInteraction");
        }
    }
}
