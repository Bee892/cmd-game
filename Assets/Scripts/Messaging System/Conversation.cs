using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversation : ScriptableObject
{
    protected List<Message> messages;
    private string recipient;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addMessage(Message m)
	{
        messages.Add(m);
	}
}
