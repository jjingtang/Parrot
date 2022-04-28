using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.WitAi;
using UnityEngine.InputSystem;


//code reference to this video: https://www.youtube.com/watch?v=SJ96P-ZhBoc

public class ActiveVoice : MonoBehaviour
{
    [SerializeField] private Wit wit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (wit == null) wit = GetComponent<Wit>();
    }

    public void TriggerPressed(InputAction.CallbackContext context)
    {
        Debug.Log("Trigger button pressed");
        if (context.performed)
        {
            WitActivate();
            Debug.Log(context.ToString());
            //wit.SendMessage(context.ToString());
        }
    }

    public void WitActivate()
    {
        Debug.Log("wit is active");
        wit.Activate();
    }
}
