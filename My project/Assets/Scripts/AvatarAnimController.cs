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
        if(values[0] == "true")
        {
            anim.SetBool("isGreeting",true);
        }
        else
        {
            anim.SetBool("isGreeting", false);

        }
    }
}
