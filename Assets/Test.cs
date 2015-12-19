using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Linq;

public class Test : MonoBehaviour {
	// Use this for initialization

	void Start () {
		TapsellDeveloper.getInstance ().setKey ("ptagbfieitrhcsitsbnfnrngfjhlijrggggcecncnpnqllqntdptlbisbllqmldlcmaoft");
		// TapsellDeveloper.getInstance ().setKey ("iniqrifnjqrdpjctfreoehbqttdomdapsnitqodntiodpllqignsqbrfopmfnppqhesefc");
		TapsellDeveloper.getInstance ().setPurchaseNotifier((String sku, String purchaseId) => { 
			TapsellDeveloper.getInstance ().consumeProduct(sku, (Boolean consumed, Boolean connected) => {
			});
			});
		DeveloperCtaInterface.getInstance().checkCtaAvailability (DeveloperCtaInterface.VIDEO_PLAY, 0, true, (Boolean connected, Boolean isAvailable) => {
			Debug.Log("test " + connected + " " + isAvailable + " 0");
		});
		DeveloperCtaInterface.getInstance().getUserInfo ((int amount) => {
			Debug.Log("test " + amount);
		});
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnGUI()
	{
		if(GUI.Button(new Rect(50, 50, 100, 100), "Test")){
			TapsellDeveloper.getInstance().startTapsell();
			// DeveloperCtaInterface.getInstance().showNewCta (DeveloperCtaInterface.VIDEO_PLAY, 0, (Boolean connected, Boolean isAvailable, int award) => {
			//	Debug.Log("test " + connected + " " + isAvailable + " " + award);
			// });
		}
	}
}
