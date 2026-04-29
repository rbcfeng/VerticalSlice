# GDIM33 Vertical Slice
## Milestone 1 Devlog

Question 1:

I've added the NPC Boss Graph that controls the transition from the exploration state to the dialogue state. When the player clicks their mouse on the NPC Boss collider, by using the node On Mouse Down, this will trigger the clickedNPC event, which references the GameController GameObject that has the clickedNPC event defined in a transition of the exploration state to the dialogue state in the State Graph. When the clickedNPC event is triggered, this causes the transition from the exploration state to the dialogue state. The dialogue state will disable the "click to interact" function when the player has their mouse hovering over the NPC Boss collider.

Question 2:

<img width="960" height="720" alt="Updated Break-down Week 1 Activity 2" src="https://github.com/user-attachments/assets/ad2771ad-c89e-46c9-8d87-79490c4bd919" />

I've added a ScriptableObjects bubble in my break-down and adjusted the player interaction with the SO bubble. By adding ScriptableObjects in my break-down, I made it clear what role ScriptableObjects have in my project and how it contributes to updating the Dialogue UI. I have also added a state machine bubble. The state machine in my project is a State Graph in the GameController GameObject, which controls the exploration state and the dialogue state. In the exploration state, there is a node called "On Mouse Over," which sets active a UI element, "click to interact." The input for the On Mouse Over node is the NPC Boss GameObject. The On Mouse Over node sets the "click to interact" UI element active whenever the player hovers their mouse over the NPC Boss collider. There is another node called "On Mouse Exit," which takes the input of the NPC Boss GameObject and sets the "click to interact" UI element false whenever the player's mouse leaves the NPC Boss collider. In the dialogue state, the On Mouse Over node sets the "click to interact" UI element to false. The exploration state allows players to interact with the objects on the screen, being prompted by the "click to interact" UI element, while the dialogue state ensures that players are not promtped to interact with anything on the screen and is engaged with the dialogue instead.

The State Graph of the GameController GameObject is related to the NPC Boss Scripting Graph. The State Graph defines the clickedNPC event in the transition between the exploration state and the dialogue state. The NPC Boss Scripting Graph then uses the clickedNPC event defined by the transition and triggers it whenever the player clicks on the NPC boss.

## Milestone 2 Devlog
Milestone 2 Devlog goes here.
## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!
