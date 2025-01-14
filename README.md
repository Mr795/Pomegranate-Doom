# Pomegranate Doom

Pomegranate Doom is a Doom source port based off of Managed Doom. Managed Doom's entire code is manually translated from [Linux Doom](https://github.com/id-Software/DOOM) with some effort to make it natural C# code. Most functionalities necessary for single player game are implemented, and now it's in the playable state.

* __Software renderering__  
    - [x] Front-to-back rendering using BSP
    - [x] Wall texture mapping
    - [x] Ceiling / floor texture mapping
    - [x] Transparent textures
    - [x] Diminishing lighting
    - [x] Sky rendering
    - [x] Sprite rendering
    - [x] High resolution rendering
    - [x] Optimization
    - [x] Fuzz effect
    - [x] Palette effects

* __Game__
    - [x] Collision detection
    - [x] Player movement
    - [x] Player attack
    - [x] Monster AI
    - [x] Doors and platforms
    - [x] Animated textures
    - [x] Demo compatibility

* __Audio__
    - [x] Sound
    - [x] Music

* __Misc__
    - [x] Status bar
    - [x] Automap
    - [x] Title screen
    - [x] Intermission screen
    - [x] Menu screen
    - [x] Save / load
    - [x] Screen melt animation
    - [x] Config
    - [x] DeHackEd support
    - [x] Frame interpolation

## License

Pomegranate Doom is distributed under the [GPLv2 license](licenses/LICENSE_ManagedDoom.txt).  
Pomegranate Doom uses the following libraries:

* [Silk.NET](https://github.com/dotnet/Silk.NET) by the the Silk.NET team ([MIT License](licenses/LICENSE_SilkNET.txt))
* [TrippyGL](https://github.com/SilkCommunity/TrippyGL) by Thomas Mizrahi ([MIT License](licenses/LICENSE_TrippyGL.txt))
* [TimGM6mb](https://musescore.org/en/handbook/soundfonts-and-sfz-files#gm_soundfonts) by Tim Brechbill ([GPLv2 license](licenses/LICENSE_TimGM6mb.txt))
* [DrippyAL](https://github.com/sinshu/DrippyAL) ([MIT License](licenses/LICENSE_DrippyAL.txt))
* [MeltySynth](https://github.com/sinshu/meltysynth/) ([MIT license](licenses/LICENSE_MeltySynth.txt))

Silk.NET uses the following native libraries:

* [GLFW](https://www.glfw.org/) ([zlib/libpng license](licenses/LICENSE_GLFW.txt))
* [OpenAL Soft](https://openal-soft.org/) ([LGPL license](licenses/LICENSE_OpenALSoft.txt))

## References

* __The Game Engine Black Book: DOOM by Fabien Sanglard__  
If you want to understand the big picture of the rendering process in Doom, buy this one.  
https://fabiensanglard.net/gebbdoom/index.html

* __The Unofficial Doom Specs by Matthew S Fell__  
http://www.gamers.org/dhs/helpdocs/dmsp1666.html

* __MUS File Format Description by Vladimir Arnost__  
https://www.doomworld.com/idgames/docs/editing/mus_form

* __Chocolate Doom by Simon Howard__  
Chocolate Doom is used as the reference of  compatibility tests.  
https://github.com/chocolate-doom/chocolate-doom

* __Crispy Doom by Fabian Greffrath__  
The minimal HUD is imported from Crispy Doom.  
https://github.com/fabiangreffrath/crispy-doom

* __Doom Wiki__  
https://doomwiki.org/wiki/Entryway

* __Eternity Engine DeHackEd / BEX Reference__  
http://eternity.mancubus.net/svn/trunk/docs/dehref.html
