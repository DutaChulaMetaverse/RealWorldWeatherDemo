using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class WeatherData : MonoBehaviour {
	private float timer;
	public float minutesBetweenUpdate;
	public WeatherInfo Info;
	public string API_key;
	private float latitude;
	private float longitude;
	public string city;
	private bool locationInitialized;
	public Text currentWeatherText;
	public GetLocation getLocation;

	public void Begin() {
		
	}
	
	void Update() {
		
	}
	
	private IEnumerator GetWeatherInfo()
	{		
		
	}
}
[Serializable]
public class WeatherInfo
{
	public Current current;
	public float cloud;
}

[Serializable]
public class Current
{
	public int last_updated_epoch;
	public string last_updated;
	public float temp_c;
	public float temp_f;
	public int is_day;
	public Condition condition;
}

[Serializable]
public class Condition
{
    public string text;
    public string icon;
    public int code;
}
