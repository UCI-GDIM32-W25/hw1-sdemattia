[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.

HW1 break-down exercise:
-UI
    -Seeds planted UI
        -Attributes
            -Text
        -Actions
            -Count goes up when player plants a seed
    -Seeds remaining UI
        -Attributes
            -Text 
        -Actions
            -Count goes down when player plants a seed
-Player
    -Attributes
        -Bunny Sprite
    -Actions
        -Movement
            -Input
                -WASD keys
            -Output
                -Player changing locations
        -Planting seeds
            -Input
                -Press space 
            -Output
                -One seed is planted at the player’s locations
                    -Only if player has seeds
                -Decreases seed count
                -Increases plant count
-Plants
    -Attributes
        -Plant Sprite
    -Actions
        -Stationary

-How do they affect each other? 
    -As the  player plants the seeds the UI changes
    -The player plants seeds
    -The plants are placed in front of the player (layers)
    -Once the seeds run out, the player cannot plant anymore 
    -Player can move through plants
    -Player can move off screen (no boundaries)



Write your Devlog here!
The break-down completed in class acted as a sort of manual as to what the game needs. It was a simple way to keep track of all the different aspects. being able to see what exactly each aspect of the game needed to do helped keep me focused and able to go through each thing one at a time. I ran into a few problems while trying to instantiate the Plant prefab but I realized that I needed to connect the prefab to the script within the Player game object and not link to the script to the prefab. This should have been common sense at this point but I am deciding to blame the long winter break for my oversight In addition, I ran into another problem while trying to set up the UI correctly. Once again my problem was in Unity and not the code. I had forgotten to link the Canvas game object--that had the PlantCountUI script attached to it--to the script in the Player game object. 

In conclusion, the break-down was very helpful for the coding part of the project but wasn't all that much help when it came to Unity. For me, I think I work best with a itemized list of what I need to do compared to a list of what the game needs to do. In the future I plan on continuing to use the break-downs but I think that I will personally need to go beyond that and create a to-do list for the Unity side of things.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
- [Monogram](https://datagoblin.itch.io/monogram) - font
- [Final Quest - 16bit Retro RPG Music audio](https://img.itch.zone/aW1nLzU1OTg2ODQucG5n/original/pMdG0Q.png) - background music