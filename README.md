# Prison break 



### Description

The controls are A and D for movement, Space For jump, LeftControl to shoot, and LeftAlt/S to stomp. 
The goal of the game is to avoid the damaging spikes kill all the guards/enemies and reach the end goal when all guards are dead. 
There are also health packs in the game that can heal the player but they can also be shot, I added this as a last second thought to stop the players from just spamming their gun. 

### 1. What types of objects can your factory create?
---

The main factory that controls all other factories can create the following objects:

1. **Enemies** – Patrolling objects with health and stompable logic.
2. **Spikes** – Hazardous objects that appear on the top or bottom of the floor.
3. **Platforms** – Objects that act as Platforms.
4. **Friendly Targets/Heals** – Objects the player should avoid shooting that heal the player.
5. **Bullets** – Player projectiles.



### 2. Why is the factory pattern a good choice for spawning these objects?
---

- **Centralized object creation** – easier initialization because all objects are spawned through spawn manager. 
- **Seperation of the spawn logic** – Spawn logic can be easily changed in the factories without impacting gameplay logic. 
- **Easier Generation of levels** – Making a generator is easier because the generator is only requesting objects rather than handling the instantiation logic.

## UML Diagram
![Alt text](Diagram%20lab2%20.png)
