# Tutorial 2

This tutorial goes over basic unity scripting in four scenes:

## Scene 1 - John Balls
This scene shows the relationship between GameObjects and Components, and how Components are interchangeable and give GameObjects behavior.

### Important concepts introduced:
GameObject-Component relationship

## Scene 2 - Bowling Alley
This scene shows how, through scripting, Component variables can be edited dynamically. Using Rigidbody as an example, this scene shows how
the variables in code match up with the inspector variables, and how hidden variables can only be accessed through scripting.

### Important code introduced:
GetComponent<T>(), Rigidbody, Start(), Monobehavior, Debug.Log()

### Important concepts introduced:
Scripting/Inspector reflexivity, Monobehaviors are Components

## Scene 3 - Malcolm's Drunken Walk
This scene shows how all the components' variables can be accessed in the same manner as Rigidbody's. Almost all of Malcolm's components can
be utilized to stop him from falling in some way, so this is a creative exercise in learning how to access components.

### Important code introduced:
transform, transform.Translate(), transform.Rotate(), Vector3, Update()

### Important concepts introduced:
Using documentation, syntactical sugar

## Scene 4 - Malcolm's Celebration
This scene shows how components can hold references to each other, in order to facilitate cross-component communication. Once a script has a
reference to another script, it can call all of that other script's public functions and access its public variables.

### Important code introduced:
None

### Important concepts introduced:
Exposing instance variables to inspector, connecting scripts via inspector, Monobehaviors are Components (again)

## Usage
Download or pull this repository. Scenes are in the Scenes/ folder, and the scripts that are supposed to be edited are in the Scripts/ folder. Anything else will be a black box for the sake of this tutorial.
