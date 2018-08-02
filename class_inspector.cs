/**************************************************
■unity struct inspector
	http://d.hatena.ne.jp/nakamura001/20110805/1312563959
**************************************************/
public class sample : MonoBehaviour {
	/****************************************
	****************************************/
	/********************
	********************/
	[System.Serializable]
	public class CAM_PARAM {
		public bool b_trace;
		public float FOV;
		public float LookAt_y;
		public float Cam_OutOfRange;
		public Vector3 eachCamPos_dir;
		public bool b_Dynamic;
		public float pos_y;
		public float radius;
		public float DegPerSec;
	}
	
	/* */
	public	CAM_PARAM[] CamParam;
	
	/****************************************
	****************************************/
	/******************************
	******************************/
	void Start () {
	}
	
	/******************************
	******************************/
	void Update () {
	}
}