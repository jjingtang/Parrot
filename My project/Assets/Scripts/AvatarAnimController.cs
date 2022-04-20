using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarAnimController : MonoBehaviour
{
    //access to the avatar allow us to modify though unity interface
    [SerializeField] GameObject avatar;
    //access to animator of this game object
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
        //if the value from wit is true, set the anim ¡°isGreeting¡± to true so the animator plays waving animation
        if (values[0] == "true")
        {
            anim.SetBool("isGreeting",true);
        }
        else
        {
            anim.SetBool("isGreeting", false);

        }
    }
}
