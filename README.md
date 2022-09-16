# MemoryGame
Written in C# and WinForms for GUI.


## Goal of the game 
The goal: to find two matching cards on the board. The faster the player does it and the fewer moves he makes, the better. Depending on the difficulty level, the player can choose from a board with a number of cards to choose from.

## Basic rules
At the beginning of each game the whole board is visible. We try to remember their positions. After that, the cards will cease to be visible and the player will have to point out the fields where the same cards are located. After clicking on a field, the card hidden underneath will be shown. We then have to point to the field where the matching card is located.

## Config
The initial visibility time, the visibility time of the reversed pair of cards, and the size of the board are subject to configuration. Changing the size of the board obviously entails changing the size of the individual card

## Screenshots 

### Welcome Window 
Username is required to identify the player, default level of the game is medium but can be changed before initialization of the game. 
<br> <br>
![Welcome Window](https://github.com/bartekf4/MemoryGame/blob/master/Images/main.png)

### Game Window 
Parameters of the window and the game are subject to configurate even during the game, which pauses accordingly.
<br> <br>
![Game Window](https://github.com/bartekf4/MemoryGame/blob/master/Images/game.png)


### High scores Window
Basic high scores table sort in descending order.
<br><br>
![High Scores Window](https://github.com/bartekf4/MemoryGame/blob/master/Images/highScores.png)


### Settings Window
Window to change the parameters of the game and the window.
<br><br>
![Settings Window](https://github.com/bartekf4/MemoryGame/blob/master/Images/settings.png) 
