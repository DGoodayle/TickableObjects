# TickableObjects
Created with the concept of seperating processing out from MonoBehaviours and into their own dedicated classes.
This is a very early stage prototype, but I've found it useful in several projects and thought it would be useful to others. So please extend it, break it, use it and let me know how you get on!

##Tickable
Derive from this class if you want its OnProcess function to be fired each frame

##TickableSkipFrame
Derive from this class if you want its OnProcess function to be fired after X amount of frames have passed

##TickableSkipTime
Derive from this class if you want its OnProcess function to be fired after X amount of time has passed
