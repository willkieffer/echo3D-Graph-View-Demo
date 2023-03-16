# [echo3D-Graph-View-Demo](https://github.com/willkieffer/echo3D-Graph-View-Demo)
 
Create a simple 3D mathematical function AR viewing application using the echo3D cloud platform. Uses a shader on unpainted function assets and allows for simple manipulation.

## Setup
* Uses Unity 2021.3.18
* Uses the free [echo3D](https://console.echo3D.co/#/auth/register) cloud service and [echo3D Unity SDK](https://medium.com/r/?url=https%3A%2F%2Fdocs.echo3d.co%2Funity%2Finstallation)
* Built for viewing on Andriod using ARCore. May require additional steps for ARKit on iOS devices

## Steps
* Using a 3D graphing program, create and export a model for the functions for viewing in AR (the "Models" folder has three examples)
* Using a 3D text program, create and export the text representation of these functions (examples can also be found in "Models")
* Upload these models to your echo3D console
* Clone "Unity Project Files" and open the scene "Final_20230222"
* Replace the echo3D API Key and entry ID for each function and sign prefab with those found on the echo3D console
* Adjust scale and rotation as necessary by adding keys and values for each asset using the "Data" tab on the echo3D console
* Build and run the app on a compatible Android device!

## Media
![Example Image](https://raw.githubusercontent.com/willkieffer/echo3D-Graph-View-Demo/main/Example%20Media/imageDemo.jpg)
![Example Video](https://raw.githubusercontent.com/willkieffer/echo3D-Graph-View-Demo/main/Example%20Media/recordingDemo.gif)

## Notes

The takeaway from this project is to learn the fundamentals of creating and adding interactions to an AR app, as well as learning how to apply a shader and material to an echo3D Hologram (it is difficult becuase the prefabs are reloaded at build and will not maintain any applied renderers). View the script "Set Materials of Child" to see the solution for this.  
