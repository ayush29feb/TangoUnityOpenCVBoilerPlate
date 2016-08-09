using UnityEngine;
using System.Runtime.InteropServices;
using System;

public class NativeAccess : MonoBehaviour {

    [DllImport("NativeLibExample")]
    private static extern int returnInt();

    [DllImport("NativeLibExample")]
    private static extern void test(IntPtr inputImage, IntPtr output);

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }
}
