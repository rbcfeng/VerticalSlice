# GDIM33 Vertical Slice
## Milestone 1 Devlog

Question 1:

I've added the NPC Boss Graph that controls the transition from the exploration state to the dialogue state. When the player clicks their mouse on the NPC Boss collider, by using the node On Mouse Down, this will trigger the clickedNPC event, which references the GameController GameObject that has the clickedNPC event defined in a transition of the exploration state to the dialogue state in the State Graph. When the clickedNPC event is triggered, this causes the transition from the exploration state to the dialogue state. The dialogue state will disable the "click to interact" function when the player has their mouse hovering over the NPC Boss collider.

Question 2:

<img width="960" height="720" alt="Updated Break-down Week 1 Activity 2" src="https://github.com/user-attachments/assets/ad2771ad-c89e-46c9-8d87-79490c4bd919" />

I've added a ScriptableObjects bubble in my break-down and adjusted the player interaction with the SO bubble. By adding ScriptableObjects in my break-down, I made it clear what role ScriptableObjects have in my project and how it contributes to updating the Dialogue UI. I have also added a state machine bubble. The state machine in my project is a State Graph in the GameController GameObject, which controls the exploration state and the dialogue state. In the exploration state, there is a node called "On Mouse Over," which sets active a UI element, "click to interact." The input for the On Mouse Over node is the NPC Boss GameObject. The On Mouse Over node sets the "click to interact" UI element active whenever the player hovers their mouse over the NPC Boss collider. There is another node called "On Mouse Exit," which takes the input of the NPC Boss GameObject and sets the "click to interact" UI element false whenever the player's mouse leaves the NPC Boss collider. In the dialogue state, the On Mouse Over node sets the "click to interact" UI element to false. The exploration state allows players to interact with the objects on the screen, being prompted by the "click to interact" UI element, while the dialogue state ensures that players are not promtped to interact with anything on the screen and is engaged with the dialogue instead.

The State Graph of the GameController GameObject is related to the NPC Boss Scripting Graph. The State Graph defines the clickedNPC event in the transition between the exploration state and the dialogue state. The NPC Boss Scripting Graph then uses the clickedNPC event defined by the transition and triggers it whenever the player clicks on the NPC boss.

## Milestone 2 Devlog

Question 1:

My complicating gameplay feature is the system of earning money from the Boss NPC to purchase an item needed to complete another NPC quest.

Step 1: Check the player if they have an object that fulfills the quest objective and let dialogue play that addresses completing the quest.

1. Create a boolean variable that is True when the player clicks on an item. Check that the default value of the boolean variable stays False when first running the game, and is set to True when players click on the item.
2. Attach a ScriptableObject that lets the completed quest dialogue play when the player successfully completes the quest. Check if this works by running the game, completing the quest, and clicking through the correct dialogue lines.
3. Attach another ScriptableObject that let the incompleted quest dialogue play when the player has not completed the quest yet. Check if this works by running the game, clicking on a player reply that creates a quest objective, then clicking on the NPC again without clicking on any items.

Step 2: Update the amount of money the player has, and the UI.

1. Create an integer variable that stores the amount of money the player has and a textbox on the Canvas that displays the amount of money. Check this by creating a Debug Log message that reports the amount of money the player has in the start of the game.
2. Once the completed quest dialogue lines reach the last index of the list of dialogue lines, increase the amount of money. Check this by creating a Debug Log message that reports the amount of money the player has after completing the quest and running through the dialogue.
3. Update the UI that reflects the amount of money the player currently has. Check this by running the game and completing the quest.

Step 3: Code a button that allows the player to purchase the right item and update the amount of money.

1. Create a button UI and an image of the NPC quest item on the Canvas and an integer variable that stores the price of the quest item. Check this by running the game and seeing if the UI scales correctly.
3. Write an if statement that checks if the amount of money the player has is enough to buy the quest item. Check this by creating a Debug Log message that returns True if the player has enough money when they click on the button.
4. Update the amount of money variable that reflects the amount of money after purchasing the quest item. Check this by creating a Debug Log message that returns the value of money left after pruchasing the quest item.
5. Update the money UI to reflect the current amount of money the player has. Check this by running the game and buying the quest item.

## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!
