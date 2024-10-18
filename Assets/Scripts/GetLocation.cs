using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class GetLocation : MonoBehaviour
{
	public LocationInfo Info;
	private float latitude;
    private float longitude;
	public string city;
    public WeatherData weatherData;
	private string IPAddress;
	
	void Start() {
		
	}
}

[Serializable]
public class LocationInfo
{
	public string status;
	public string country;
	public string countryCode;
	public string region;
	public string regionName;
	public string city;
	public string zip;
	public float lat;
	public float lon;
	public string timezone;
	public string isp;
	public string org;
	public string @as;
	public string query;
}
