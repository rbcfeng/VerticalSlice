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

Question 2:

My task break-down and quiz question didn't really help me build the feature for my Milestone because they were a bit simple. I ended up encountering a lot of different bugs and had to find some stuff that weren't outlined in the break-down or question. I think in the future, I might reference more specific steps, like how I'm going to use a ScriptableObject and what kind of events I'm going to create.

Question 3:

<img width="575" height="365" alt="Screenshot 2026-05-16 002012" src="https://github.com/user-attachments/assets/8eae774d-a039-4ada-8805-fcb2cd3fe054" />

In my PurchaseButton.cs script, I referenced a Scene variable in Visual Scripting called amount_of_money. amount_of_money is added $5 in Visual Scripting when the player completes the phone quest, and is subtracted when the Purchase() method in PurchaseButton.cs is called, when clicking on the "Purchase" button. The Purchase() method gets the amount_of_money Scene variable and modifies its value from the line "amount_of_money = (int)Variables.Scene(Boss).Get("amount of money");." The following statements modify the value of amount_of_money. Referencing variables from Visual Scripting in C# scripts can help declutter some of the code in the scripting graphs and make the nodes more readable.

Question 4:

The Unity System to grade is the ScriptableObject dialogue nodes. Most of the system is represented in Visual Scripting in the NPC scripting graph and the ScritpableObjects are in the Dialogues folder in the Assets folder.

## Milestone 3 Devlog

Question 1:

<img width="1144" height="736" alt="Screenshot 2026-05-29 231912" src="https://github.com/user-attachments/assets/ec0954b2-f4a2-4a06-a5e0-ec83b223d5c9" />

I created a Lighting ShaderGraph that creates a shiny rendering effect on the phone item in the office entrance scene when the lights are turned on. Currently, there is no way to turn the lights off, which will disable the rendering effect.
My Lighting ShaderGraph uses the main texture of the phone item as a base color of the fragment of the vertex. The main texture is added with the shiny texture, which is a texture 2D of a white shiny image. The shiny texture is created by adding fraction of time for the movement of the shine, since time is increasing, with the UV node. The normal of the fragment uses the normal map parameter, which controls how light interacts with the phone item, which is flat. The flatness of the items would be consistent with the flat style of the game. The fragment also uses a mask texture to control where the the sprite receives the light, which would be the entire phone item. The fragment uses the alpha value of the main texture of the phone item.

Question 2:

I've improved putting the quest items in different areas, rather than right next to the boss NPC to add more difficulty to the level. I've also created a gameplay loop that triggers player options again to run through other player replies.

Question 3:

I've added more scenes and backgrounds to the game, as well as more items to collect, and buttons that change scenes and a purchase button. Changing scenes and adding more items contribute to the gameplay loop of collecting items to gain money, so that the player could eventually afford to purchase the game console in the thrift shop scene.

## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- phone, camera, music CD, and game console item - sketchfab.com
- thrift store image - unsplash.com
- conference room, break room, office entrance, and main office room - archello.com
