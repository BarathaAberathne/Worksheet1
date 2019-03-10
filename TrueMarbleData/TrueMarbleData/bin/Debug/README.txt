
TRUE MARBLE FOR COMP3006
--------------------------------------------------------------------------------

TrueMarble is a set of satellite images of the entire Earth provided at varying
levels of resolution, ranging from 128km per pixel down to 0.5km per pixel.
It is made available by Unearthed Outdoors LLC (http://www.unearthedoutdoors.net/)
under the Creative Commons license (http://creativecommons.org/licenses/by/3.0/us/).


For the purposes of Distributed Computing , the TrueMarble images are split into
256x256 tiles and a DLL was created to control access to these tiles
(in effect, the DLL is the Data tier in a multi-tiered architecture).
Practicals are then about building Google Maps-style systems to browse
the Earth satellite imagery with several different component technologies
and different front-ends (GUI, browser) in order to gain an appreciation of
the design challenges of modern component-based software development.

In a real word situation you would install the library on the machine and then
access its location. However, as we do not have root access to the lab machines,
and to easily allow for you to utilise the library on your home machine/s we will
just be putting it in a relative directory. this is not ideal, but is the
easiest way around requiring root. 
