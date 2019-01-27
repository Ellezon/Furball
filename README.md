# Furball
The aim of this project was to create a fun and interactive game to help 10 – 12 year olds understand the basic concepts of programming with Prolog. Our game, Furball, was designed using Unity and is intended to teach recursion, backtracking and pattern matching. 

Furball consists of 5 levels. In the first level a treasure chest is shown to the player. This chest is locked and can only be opened by using a key found in a later level. The aim of the game is to solve all levels and return to open this chest.   

In every level the player must collect furflies to break down walls and solve the level. Each furlfly is coloured and on collection, the same coloured wall is destroyed. Thus, the user must solve this pattern matching puzzle to advance to the next level. This mimics recursion as each level corresponds to a simpler version of the first level.  

Upon solving the third level, the user obtains the key and must return to the previous levels to reach the chest (main goal) once more. The revisited levels have the same basic structure but the furflies and their walls have moved to form a new puzzle. Going through these levels once more brings about the idea of backtracking, reaching the base case and unwinding to solve the main goal. 

