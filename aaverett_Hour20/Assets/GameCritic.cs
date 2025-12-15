/*
QUESTIONS
1) Is the game too easy or hard?
- The game is a little easy; I did not die too often or too little. 
  My first test run was 43 seconds. I don't think the obstacles are too frequent. Maybe
  the slow down time could be longer. Power-ups match well with the obstacles and time.

- Describe what you experienced. Include specifics (examples: how often you died, how long you survived, how quickly you learned the controls).
- Explain why it feels easy or hard (examples: obstacles too frequent, player too slow, power-ups too rare, time runs out too quickly).
- Mention at least one moment in gameplay that proves your point.

2) What changes would you do to make it easier or harder?
- Change slow down duration -> harder
- Adjust camera angle -> easier navigation
- Add more obstacles (walls to run into, space arrows, jump over stuff) -> harder

3) What would make the game more appealing?
- Add different types of power ups (speed, health, invincible, score multipliers, etc)
- Add sound effects
- Add a designed UI (make it pretty but also color changes when low time and have power ups)
- Design the enviornment with more space/sci-fi elements
- Speed increases more noticably over time

4) What parts of the game are fun?
- Dodging the obstacles is the most fun part of the game. 
- The time at the bottom also makes it fun, since it makes you more motivated to play quickly.

5) What parts of the game are tedious?
- The game can become tedious when similar obstacles repeat too frequently without variation. 
- Losing time quickly after a small mistake can feel boring; I think adding different obstacles
  that correlate to different health outcomes.

NOTE
I did not know you already had the scripts in a folder from the link in the directions
because it advised us not to copy and paste. I am crying.

CHANGES TO ASSETS
1) Powerup
    - Changed model from sphere to sphere with bumps
    - Added Glass 3 material to the bumps from PBD Materials Variety Pack
    - Added Grass 3 texture to the base from PBD Materials Variety Pack
    - Changed light from yellow to bright neon pink
    - Particle System:
      - Changed emission to BURST-based one
      - Rate over Time set to 0
      - Added a single burst (18 particles at time 0)
      - Reduced Shape radius from 1 to 0.15
      - Start Speed changed to 5
      - Increased Start Lifetime to 5 seconds
      - Changed Render Mode from Stretched Billboard to Billboard
      - Adjusted Shape scale to 0.5 on all axes
      - Start Color changed to a bright neon pink
2) Obstacle
    - Changed model from sphere to sphere with spikes
    - Added Metal 3 material to the base from PBD Materials Variety Pack
    - Added Metal 3 texture to the spikes from PBD Materials Variety Pack
*/