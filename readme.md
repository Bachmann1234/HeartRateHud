# Heart Rate HUB
## Display your heart rate on your computer, without getting in the way

This will connect to and display your heart rate as displayed by the [CMS50D+](http://www.amazon.com/CMS-Finger-Pulse-Oximeter-Sofware/dp/B00B8L8ZXE)

The project assums you have an environment variable set "CMSPort" which should be the port the device is connected to. (Example: COM3)

The project will attempt to connect 3 times. Qutting if it fails.

Once a connection is established the heart rate will display at the top of the screen. The window that appears is transparent and all mouse events pass though. Allowing this HUD to play over everything else you are doing on your machine.

![Project in action](/InAction.png?raw=true "Optional Title")

### Notes and expectation setting
This is my first C#/windows gui project. There was a lot of "Um, how do I do x?". 

Here are some credits for the curious

[Transparent background](http://stackoverflow.com/questions/4314215/c-sharp-transparent-form)

[Passthough](http://stackoverflow.com/questions/173579/how-to-pass-mouse-events-to-applications-behind-mine-in-c-vista)

[Serial Communication](http://stackoverflow.com/questions/1243070/how-to-read-and-write-from-the-serial-port)

[CMS50D+ Interface Code adapted from](https://github.com/atbrask/CMS50Dplus)

I literally just got this thing working so I probably got some bugs to figure out and I probably need more error handling with device communication
