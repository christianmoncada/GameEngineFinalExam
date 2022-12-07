# GameEngineFinalExam

For Question 7, I created a score manager as my management system. The score manager counts the number of coins you collect (blue spheres), and prints your current score in the console. 

This manager benefits the designated game Pac-Man, because pac man has a score manager.

I implemented this manager, by creating a coin script and score manager script. the coin script is placed on coins in the game, and when the player collides with the coin, the object is deleted and the coin script calls the add score function in the score manager script. In the add score function, the score equals its value before picking up the coin + 1, afterwards the script prints the player's current score.
