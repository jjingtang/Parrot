using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarAnimController : MonoBehaviour
{
    //access to the avatar
    [SerializeField] GameObject avatar;
    private Animator anim;
    


    // Start is called before the first frame update
    void Start()
    {
        anim = avatar.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Greeting(string[] values)
    {
        var actionString = values[0];
        if (string.IsNullOrEmpty(actionString)) return;

        if (actionString == "hello")
        {
            Debug.Log("wit output value is true, perform greeting action");
            anim.SetBool("isGreeting",true);
            return;
        }
        else
        {
            anim.SetBool("isGreeting", false);
            return;
        }
    }
}
