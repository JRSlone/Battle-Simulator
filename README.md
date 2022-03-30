# Battle-Simulator

This is my take on a simple back and forth battle sim following a style like Fire Emblem where combat follows a rock, paper, scissors style of advantage and disadvantage. You will be able to create a named character and use it for as many games as you wish to play and even load that same character the next time you play to pick off where you left off in terms of wins and losses. During combat the players will use their available weapons to attack the enemy and during the combat the program will determine which side had the advantage in the fight and deliver additional damage to the side with the losing weapon.

The 3+ additional features I selected were as follows:
- Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program.
  -[Main loop for the program as the fights occurs]
- Create an additional class which inherits one or more properties from its parent.
  -[The axe, sword, and lance class all inherit from the AllWeapon Class]
- Read data from an external file, such as text, JSON, CSV, etc and use that data in your application
  -[Text file that is saved to once the user types exit when prompted at the end of the game round. Can also load that info by typing your character name at beginning of program when prompted for laoding a save file.]
- Calculate and display data based on an external factor (ex: get the current date, and display how many days remaining until some event)
  -[During the loop, while the player fights the adversary Health is calculated from the damage from weapons to each other.]
