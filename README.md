# 01-maze-audiocode-sfeld

### Project description: 
#### Konzept: 
Das Labyrinth befindet sich in einem verzauberten Frühlingswald, welcher mit verschiedenen leuchtenden Kreaturen und Pflanzen besiedelt ist. Des Ziel ist es mit seiner Lampe 3 verschiedene magische Tiere einzusammeln und zu einem großen Baum in der Mitte des Irrgartens zu bringen. Dafür erhält man im Gegenzug einen Schlüssel, um die Tür am Ende des Labyrinths aufzusperren. Mindestens eins dieser Tiere kann nur durch lösen eines Rätsels oder einer Aufgabe erreicht werden.
#### Layout 
Am Eingang des Maze findet man eine Lampe, welche für den Rest des Spiels essenziell ist. Der Ausgang ist durch eine große Tür versperrt welche nur mit passendem Schlüssel geöffnet werden kann.
Durch leichtes Flügelflattern und Rascheln wird der Spieler in Richtung der Motten geleitet. (OPTIONAL: leuchtende Wurzeln die leicht um die Ecke wachsen geben ebenso einen kleinen Hinweis.) Wenn man die Lampe in Richtung der Motten hält schwirren sie hinein und können transportiert werden (Animation Optional)
Der Weg wird an einer Stelle durch eine tiefe Schlucht blockiert. Der Spieler muss mit einer leuchtenden Kugel eine Zielscheibe treffen, um eine Brücke erscheinen zu lassen.
Tiefer im Labyrinth findet man einen großen Baum dessen Krone weit über die Mauern ragt, von ihm ist Vogelgezwitscher zu hören. Stellt man seine Lampe vor ihm ab, leuchte eines der Lichter vor dem Baum auf.
Sind alle drei Tiere abgeliefert, erhält der Spieler als Belohnung einen den Schüssel zum Ausgang 


### Development platform: 
OS: Windows 10, Game Engine: Unity 2019.1.14f1, Visual Studio 2019, Steam,  
SteamVR 2.5.0 (https://github.com/ValveSoftware/steamvr_unity_plugin/releases/tag/2.5.0)

Note on Unity Version 2019.1.14f1 and SteamVR: The SteamVr plugin has many issues when used with Unity Versions > 2019.1.3 because the XR Management System changed from 2019.1.3 to 2019.1.4. Valve is working on it, so we will use these older versions for the VR programming.  
Download steamvr_2_5_08_19.unitypackage, import the package: Assets --> Import Package --> Custome Package

## Software/Hardware Requirements: 
Unity hardware requirements https://docs.unity3d.com/2019.1/Documentation/Manual/system-requirements.html 
Oculus hardware requirements https://support.oculus.com/248749509016567/
Steam has to be installed
SteamVR has to be installed
You need a VR headset in this case an Oculus Rift

First open Oculus software, second open SteamVR (or start game from unity), otherwise some strange errors will happen. 


### Target platform: 
Oculus Rift/S, Vive; 
Tested on Oculus Rift S

### Visuals: 
![screenshot](https://github.com/4ahmnm2021-G3-G4/01-maze-audiocode-sfeld/blob/main/Playtest.mp4)


Screenshots (concept and experience), Video
#### Layout Sketch
![screenshot](https://github.com/4ahmnm2021-G3-G4/01-maze-audiocode-sfeld/blob/AudioSources/layout.png?raw=true)

### Third party material: 
(if used Fonts, Sounds, Music, Graphics, Materials, Code etc.)


**Sounds** 

 - Sounds: Fresound and the BBC Library,

**Code**

 - Enum with switch case c# https://stackoverflow.com/questions/15136134/c-sharp-how-to-use-enum-with-switch

**Other** 
 - Water Shader: "Unity Standard Assets 2018.4" 
 -   Skybox: Unity Asset Store "AllSky Free - 10 Sky / Skybox Set"
- Firefly Tutorial + Sprites: https://youtu.be/41hAlLk8AiQ
- 
**Textures** 
 - Wall Texture: Textures.com

**Models**
 - Lamp Model:  https://sketchfab.com/3d-models/lantern-f0b0ea89f20b4f10bb583c449ae04d9c
 - Trees and Folliage: Unity Assets Store "Nature Starter Kit 2" ,
   ALP8310 Grass Flowers Pack Free
 

 - Magic Tree Mosdell: Vici
 - Wood Planks Model: "Wood Plank" (https://skfb.ly/6pVzI) by DAYlirious is
   licensed under Creative Commons Attribution
   (http://creativecommons.org/licenses/by/4.0/).
 - Lock Model: "low_poly_lock" (https://skfb.ly/6TLZw) by samuglz6 is
   licensed under Creative Commons Attribution
   (http://creativecommons.org/licenses/by/4.0/).
 - Fish Model: "Koi Fish" (https://skfb.ly/6SuYV) by lesliestowe is
   licensed under Creative Commons Attribution
   (http://creativecommons.org/licenses/by/4.0/).
 - Key Model: "Old Key" (https://skfb.ly/6QZC6) by TheFalkonett is
   licensed under Creative Commons Attribution
   (http://creativecommons.org/licenses/by/4.0/).
   (http://creativecommons.org/licenses/by/4.0/).
 - Tartget Model: "Target (archery)" (https://skfb.ly/onQWU) by Arkikon
   is licensed under Creative Commons Attribution
   (http://creativecommons.org/licenses/by/4.0/).
 - Altar Model: "blood altar" (https://skfb.ly/6WQBx) by runsbuns is
   licensed under Creative Commons Attribution
   (http://creativecommons.org/licenses/by/4.0/).
 - Rock Model: Unity Assets Store: "Rock package"


### Project state: 
99%/100% finished
<progress max="100" value="2"></progress>

### Limitations: 
My inability to spell anything right :( 
(I've read through this 3 times now, very sorry if I didn't catch all the misstakes)

### Lessons Learned: 
How to use enums in combination with switch statements

How to add dynamic foliagge


Copyright by Sfeld ( •_•)
