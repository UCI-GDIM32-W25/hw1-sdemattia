[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
- UI
    - Seeds planted UI
        - Attributes
            - Text
        - Actions
            - Count goes up when player plants a seed
    - Seeds remaining UI
        - Attributes
            - Text 
        - Actions
            - Count goes down when player plants a seed
- Player
    - Attributes
        - Bunny Sprite
    - Actions
        - Movement
            - Input
                - WASD keys
            - Output
                - Player changing locations
        - Planting seeds
            - Input
                - Press space 
            - Output
                - One seed is planted at the player’s locations
                    - Only if player has seeds
                - Decreases seed count
                - Increases plant count
- Plants
    - Attributes
        - Plant Sprite
    - Actions
        - Stationary

- How do they affect each other? 
    - As the player plants the seeds the UI changes
    - The player plants seeds
    - The plants are placed in front of the player (layers)
    - Once the seeds run out, the player cannot plant anymore 
    - Player can move through plants
    - Player can move off screen (no boundaries)

## Devlog
The break-down completed in class acted as a sort of manual as to what the game needs. It was a simple way to keep track of all the different aspects. being able to see what exactly each aspect of the game needed to do helped keep me focused and able to go through each thing one at a time. I ran into a few problems while trying to instantiate the Plant prefab but I realized that I needed to connect the prefab to the script within the Player game object and not link to the script to the prefab. This should have been common sense at this point but I am deciding to blame the long winter break for my oversight In addition, I ran into another problem while trying to set up the UI correctly. Once again my problem was in Unity and not the code. I had forgotten to link the Canvas game object--that had the PlantCountUI script attached to it--to the script in the Player game object. 

In conclusion, the break-down was very helpful for the coding part of the project but wasn't all that much help when it came to Unity. For me, I think I work best with a itemized list of what I need to do compared to a list of what the game needs to do. In the future I plan on continuing to use the break-downs but I think that I will personally need to go beyond that and create a to-do list for the Unity side of things.

## Devlog Redo
The break-down completed in class was not the most helpful for me personally but I did use it specifically for the actions that each GameObject needed to complete and how they were connected to each other. For example, I used the input section of the Player section and turned that into the Update() function in the Player script. This was helpful in that it was listed out simply and was easy to turn into code. In addition, seeing how different GameObjects were linked together visually was also helpful. In my PlantCountUI script I knew to make the "seeds remaining UI" and "seeds left UI" within it since it was all contained under the same section. Visually the break-down was very useful while coding but in a process and to-do sense, it added more confusion. Though it made the process a bit more muddled it did help with going over the final result, I went through each GameObject in Unity and made sure that it was properly assigned to the right script according to the break-down (eg. the _plantcountUI and _seedsRemainingUI were assigned to the correct TMP GameObjects).

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
- [Monogram](https://datagoblin.itch.io/monogram) - font
- [Final Quest - 16bit Retro RPG Music audio](https://img.itch.zone/aW1nLzU1OTg2ODQucG5n/original/pMdG0Q.png) - background music

## Prof comments
I'm very glad to hear that the break-down helped your coding process, and that you already have some more insight as to how formatting your break-down differently would be more helpful for you. I'm interested to hear if the HW2 break-down is more or less helpful.

Unfortunately, I cannot give this Devlog full points because you did not clearly connect anything from your code to the break-down. You described a problem you solved like we did in our Devlogs last quarter, but you didn't need to do that for this Devlog. This Devlog's prompt asked you to describe how your code related to the break-down you did- you described how the break-down affected your thought process, but not how it related to your code. For example, instead of talking about a probelm you solved with the PlantCountUI script, I would have written some details about how the PlantCountUI script was implementing the "seeds planted UI" and "seeds remaining UI" objects you mentioned in the break-down.

Make sure to read the prompt carefully for HW2, and I'm very confident you can get full credit for it! :)

Please also make sure to put your break-down in the right section (I've moved it for an example). You can also remove the prompts (after reading them thoroughly ;P - you can also always read them on the assignment page on Canvas). This will all make it a lot easier for me to read.
