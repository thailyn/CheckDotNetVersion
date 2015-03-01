Check .NET Version
==================
This is a very tiny program that checks and prints out which versions of the
.NET Framework you have installed.  It does so by reading information from
some registry keys.

It is possible the program will not have permission to check the registry.  If
that turns out to be the case, hopefully, it will tell you, instead of
crashing.

Also, the program requires at least version 2.0 of the .NET Framework
installed in order to run -- that is the lowest version I can require through
the menus of Visual Studio 2013.  If this program does not run due to an
insufficient version of .NET, then you can rest assured that your machine is
ancient.

The method to check the registry is based on a Stack Overflow answer located
[here](http://stackoverflow.com/a/15926268) (which in turn was based off of
some other web sites).

This work is licensed under the Creative Commons Attribution-ShareAlike 3.0
Unported License. To view a copy of this license, visit
http://creativecommons.org/licenses/by-sa/3.0/ or send a letter to
Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
