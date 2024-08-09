--Made By WRD
--[[ Configuration ]]--

--If true, 
	--Players on the same team will not be aimed at
	--Will not work in games with custom team systems
--If false,
	--All players in the game will be aimed at
    _G.WRDAimbotTeamCheck = false

    --If true, 
        --Simulates mouse movement. Its as if you actually moved your mouse onto the player, meaning this is harder to detect
        --Tradeoff is it comes with a lot of bugs. Lacks smoothness, not 100% accurate, and can't aim at players dirrectly behind.
    --If false, 
        --Will use camera manipulation. 
        --This is the smoothest and most accurate, but games can detect this easy. Be careful with what games you use false in.
        --May be buggy for 3rd person games!
    _G.WRDAimbotBypass = false
    
    --If true, the aimbot will only look for the closest visible player
        --Buggy for 3rd person games!
        --May cause heavy lag
    --If false, the aimbot will look for all players, even if they're behind a wall
    _G.WRDAimBotWallcheck = false
    
    --[[ 
    
    Additional Notes | August 17, 2019
    
    *This was made for exploits using the WeAreDevs API, such as JJSploit.
    *Please don't steal credits. I worked pretty hard on this ;c
    *This should be able to work in all games using default Roblox character systems. Games using using custom/modified characters may be buggy, such as Strucid and Phantom Forces.
    *You don't need to rexecute the entire script to change configuration above. You could simply execute the desired configuration line.
    *Rexecuting the script should not cause issues
    *The WRDAimbotBypass enabled bug involving players behind you will be fixed eventually. Be sure to check the website time to time!
    *Aimbot starts when you hold the right mouse button
    *This aimbot snaps aims to the closest player's head.
    *Please change the configuration below appropriately.
    *Check the website occasionally for updates!
    
    ]]--
    
 loadstring(game:HttpGet("https://cdn.wearedevs.net/scripts/WRD Aimbot.txt"))
