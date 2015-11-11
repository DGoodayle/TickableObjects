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
/// The base Tickable class
/// </summary>
public class Tickable
{
    /// <summary>
    /// Frame Ticked, by default fire the on process function
    /// </summary>
    public virtual void Tick() { OnProcess(); }
    /// <summary>
    /// Process function
    /// </summary>
    protected virtual void OnProcess() {}
}
/// <summary>
/// A Tickable class that only fires every X amount of frames
/// </summary>
public class TickableSkipFrame : Tickable
{
    private int m_iFramesToSkip;
    private int m_iFrameCount;
    /// <summary>
    /// Constructor for the TickableSkipFrame class
    /// </summary>
    /// <param name="framesToSkip">Number of frames to skip</param>
    public TickableSkipFrame(int framesToSkip)
    {
        m_iFramesToSkip = framesToSkip;
    }
    /// <summary>
    /// If the count equals the frame to skip value, then fire the OnProcess() function, else do nothing.
    /// </summary>
    public override void Tick()
    {
        if(m_iFrameCount == m_iFramesToSkip)
        {
            m_iFrameCount = 0;
            OnProcess();
        }
        //Increment the frame count
        m_iFrameCount++;
    }
}
/// <summary>
/// A Tickable class that fires every X amount of seconds
/// </summary>
public class TickableSkipTime : Tickable
{
    private float m_fTimeToSkip;
    private float m_fTimeCount;
    /// <summary>
    /// Constructor for the TickableSkipTime class
    /// </summary>
    /// <param name="time">Time in seconds</param>
    public TickableSkipTime(float time)
    {
        m_fTimeToSkip = time;
    }
    /// <summary>
    /// Tick the function, increment the count by the frames delta time and if the count is greater than the time to wait then fire the OnProcess() function
    /// </summary>
    public override void Tick()
    {
        if(m_fTimeCount>= m_fTimeToSkip)
        {
            //Wrap the value to make sure we don't lose any time.
            m_fTimeCount -= m_fTimeToSkip;
            OnProcess();
        }
        //Increment the count based on the frame delta time.
        m_fTimeCount += Time.deltaTime;
    }
}
