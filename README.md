# CrestronHelperLibraries
A list of Helper Libraries to facilitate the transition from SIMP to SIMPL#Pro

The list of helper libraries shown here were created to facilitate the season SIMPL programmer move into SIMPL# programming.  As a season SIMPL programmer myself, and after spending a considerable amount of time learning C#, and object oriented programming, it was still hard to jump into SIMPL# and understand how to make a processor work the same way I was able to with SIMPL.  In the beginning I found it challenging to understand how the CrestronControlSystem class worked. Initializing slots and consume events was also not as straight forward as it was with SIMPL. Going to a more advance Multimedia processor like the DMPS-4K-150-C was even more challenging.

So, after some trial and error and some research I decided to ease the transition for a SIMPL programmer into SIMPL# by creating helper classes that will follow more or less the process on how we normally work with SIMPL. 

In SIMPL the first thing we normally do is choose the processor we are going to work with.  When that is chosen, the list of available ports, cards, etc. are presented to us, ready to work on.

Similarly, in the helper classes I created, so far, two fully configured processors, a CP3/CP3N and a DMPS-4K-150.

So, feel free to fork this repository into the project that you want to try, and delete the processors you don't want to use. Do not delete the Libraries folder.

When you open in Visual Studio 2008, the processor that you want to use, a prepopulated ControlSystem.CS program that has all the cards that the processor uses will open.

The cards will be instantiated objects that will mimic the programming blocks found on SIMPL.  The objects will be named as similarly as possible to their counterparts in SIMPL.

So, for example Slot-05 of a CP3 will be named C2I-CP3-RY8, just like the same slot on SIMPL. You can find that object by expanding the region labeled Onboard Devices.

The C2I-CP3-RY8 object is a class that mimics the same object in SIMPL. 
-  It will have read only properties that will correspond to the outputs of the  SIMPL C2I-CP3-RY8 block: C2I-CP3-RY8.A1_F is the same as the A1_F output found on Slot-05 block of the CP3.  
-  It will have write only properties that will correspond to the Inputs of the SIMP C2I-CP3-RY8 block: C2I-CP3-RY8.A1 is the same as the A1 input found on Slot-05 block of the CP3.
-  Since SIMPL#pro is an event based programming system, instead of a logic wave based system like SIMPL, a program must subscribe to events to listen for changes (very similar on how SIMPL+ has event handlers that listens to inputs into its code).  The C2I-CP3-RY8 therefore has exposed individual events per relay, just like SIMPL does.  So, when a relay changes its state either by the running program or some other program in a different slot, it is possible to listen to that event using the C2I-CP3-RY8.A1_F_Changed event and subscribing to it

The same thinking is applied to other modules of the CP3.

My hopes are that this will decrease the learning curve to get familiar with SIMPL#pro.  If you find it useful feel free to contribute by using the same architecture to build templates for other processors like the PRO3, DMPS3-4K-300-C, fixing or creating documentation, etc.

Open issues if you find errors, contribute to projects, etc.
