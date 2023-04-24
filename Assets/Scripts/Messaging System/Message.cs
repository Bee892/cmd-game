using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message : ScriptableObject
{
    public struct Time
	{
        public int hour;
        public int minute;
	}

    private string sender;
    private string content;
    private Time timeOfMessage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Message()
	{

	}

    public string getSender()
	{
        return sender;
	}

    public string getContent()
	{
        return content;
	}

    public Time getTime()
	{
        return timeOfMessage;
	}

    public void setSender(string name)
	{
        sender = name;
	}

    public void setContent(string cont)
	{
        content = cont;
	}

    public void setTime(Time t)
	{
        timeOfMessage = t;
	}

    public void setTime(int h, int m)
	{
        timeOfMessage = new Time();
        timeOfMessage.hour = h;
        timeOfMessage.minute = m;
	}
}
