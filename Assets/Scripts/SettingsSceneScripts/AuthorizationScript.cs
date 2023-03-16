using Assets.Data;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class AuthorizationScript : MonoBehaviour
{
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

    public void Authorize()
    {
        if(email.text != "" && password.text != "") 
        {
            User storagedUser = JsonConvert.DeserializeObject<User>(PlayerPrefs.GetString("PlayerData"));
            if(storagedUser != null)
            {
                if(storagedUser.Email == email.text && storagedUser.Password == password.text) 
                {
                    SceneManager.LoadScene("MainScene");
                }
            }
        }
    }
}
