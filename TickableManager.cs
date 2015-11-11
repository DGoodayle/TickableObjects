/*
Tickable Classes by Just a Pixel - Danny Goodayle (@DGoodayle) - http://www.justapixel.co.uk

The MIT License (MIT)

Copyright (c) 2015 DGoodayle

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using UnityEngine;
using System.Collections.Generic;
/// <summary>
/// This is a basic implementation of a manager class for Tickable objects.
/// We utilize the Unity Update() loop to tick each object individually.
/// This is just a proof of concept at this point, I believe it will require a more robust design for any production projects
/// </summary>
public class TickableManager : MonoBehaviour {
    private List<Tickable> tickableObjects;
	void Start () {
        tickableObjects = new List<Tickable>();
        //Add a standard tickable object to the list, ticking each frame and outputting a message
        tickableObjects.Add(new TickableClass());
        //Add a tickable object which only ticks every 20 frames, outputting a message
        tickableObjects.Add(new TickableClassWithFrameSkip(20));
        //Add a tickable object which only ticks every 0.5 seconds, outputting a message
        tickableObjects.Add(new TickableClassWithTimeSkip(0.5f));
    }
	
	//Using Unitys update function, we loop over all of the objects in the tickable object list, and individually tick them.
    //This allows the tickable classes to be very lightweight instead of deriving from a MonoBehaviour
	void Update () {
        for(int i = 0; i < tickableObjects.Count; i++)
        {
            tickableObjects[i].Tick();
        }
	}
}
