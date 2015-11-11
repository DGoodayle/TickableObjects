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

/// <summary>
///  Demo implementation with a basic output each time OnProcess is called
/// </summary>
public class TickableClass : Tickable
{
    protected override void OnProcess()
    {
        Debug.LogFormat("<color=red>Tick {0}</color>", this);
    }
}

/// <summary>
/// Demo implementation with a basic output each time OnProcess is called every X amount of frames
/// </summary>
public class TickableClassWithFrameSkip : TickableSkipFrame
{
    public TickableClassWithFrameSkip(int framesToSkip) : base(framesToSkip)
    { }
    protected override void OnProcess()
    {
        Debug.LogFormat("<color=green>Tick {0}</color>", this);
    }
}

/// <summary>
/// Demo implementation with a basic output each time OnProcess is called every X amount of seconds
/// </summary>
public class TickableClassWithTimeSkip : TickableSkipTime
{
    public TickableClassWithTimeSkip(float timeToSkip) : base(timeToSkip)
    { }
    protected override void OnProcess()
    {
        Debug.LogFormat("<color=yellow>Tick {0}</color>", this);
    }
}
