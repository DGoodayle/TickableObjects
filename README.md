# TickableObjects
Created with the concept of seperating processing out from MonoBehaviours and into their own dedicated classes.

##This is a prototype!
This is a very early stage prototype, i've been looking into ways of seperating out MonoBehaviour classes into a lightweight class which simply processes data when required and this is just one of the way's I've thought of. I intend to add to this as I go in the hopes of finding a flexible, lightweight solution that can be shared with others.

###TickableManager
This is a demo class designed to show you a simple way of using the prototype, simply attach this script to any game object.
In a real-world situation this would have several Tickable processes assigned to it which would contain functionality within.

For example: An AI game object would contain a manager with a reference to a TickableSkipFrame class. This TickableSkipFrame class would ensure the AI logic isn't fired each frame (as it would, if running in the Update() function) and is instead fired every X amount of frames.

###Tickable
Derive from this class if you want its OnProcess function to be fired each frame
Any code in the OnProcess function will be called each frame

###TickableSkipFrame
Derive from this class if you want its OnProcess function to be fired after X amount of frames have passed
Any code in the OnProcess function will be called every X amount of frames

###TickableSkipTime
Derive from this class if you want its OnProcess function to be fired after X amount of time has passed
Any code in the OnProcess function will be called every X amount of seconds
