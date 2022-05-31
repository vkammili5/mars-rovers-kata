# mars-rovers-kata

The main task of this kata is to create a program to move rovers around surface of Mars!
Here the surface of the mars is represented by a Plateau. For this task, considering the plateau as square.

# Rover's Position on the Plateau:

In this task, the rovers position is represented by x and y coordinates and the letters N,E,W and S represent North, East, West and South respectively.
For example :  0 0 N - this mean that the rover is at the bottom - left corner facing in the North direction. 

# Instructions to the rover to move around the the plateau : 

So to move a rover around the plateau, a string of letters is sent to a rover.
The letters and their resultant action is shown below:

![image](https://user-images.githubusercontent.com/104863175/171136425-59914de9-80b2-4405-9adc-dc5659d9b5d4.png)

# Inputs of the program :

# First Line of Input to the Program :

The first line inputted into the program represents the upper-right coordinates of the Plateau.
5 5

This Plateau has maximum (x, y) co-ordinates of (5, 5).
N.B. Assume that the lower-left coordinates is (0, 0).

# Subsequent Lines of Input into the Program - Input to Rovers :

This represents the instructions to move the rovers.
Each rover receives # two lines of input.

# First Line of Input to a Rover
The Rover’s position is represented by two integers representing the X and Y coordinates and a letter representing where the Rover is facing (its
orientation).
1 2 N

# Second Line of Input to a Rover

A string of letters representing the instructions to move the Rover around the Plateau.
