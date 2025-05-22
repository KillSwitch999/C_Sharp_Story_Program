using System;
using System.Diagnostics;

namespace CSharpStory_MathOperations

{
    class Program
    {
        //Math Operation Methods Can Be Found On Lines 1353-1392
        
        static void PauseAndClear()
        {
            //Pauses the program and requires the user to press enter to continue, while clearing screen of previous text

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();

        }

        static void ClearScreen()
        {
            Console.Clear();

        }

        static void Introduction()

        {
            Console.WriteLine(
                "Everything within this story is purely fictional. This is a matured rated story. The best kind.");
            PauseAndClear();

        }

        static void GreetUser()
        {
            //Message to welcome user into story

            Console.WriteLine(
                $"Welcome to our world, user!\nThis is our space to make the fuckin' magic happen.\nIf you may so kindly place your User ID (name, tag, or initial. Whatever floats your boat.), so I know what to call you, I will greatly appreciate it.");

        }

        static string GetUserName()
        {
            //Ask user for what they wish to be called

            Console.WriteLine("Enter your User ID:");

            string username = Console.ReadLine();

            ClearScreen();

            //Greeting to user based on their username choice

            Console.WriteLine(
                $"Hello, {username}! We are heading on a virtual adventure together!\nAt this moment in time, I may not be able to give you a video like visual of this adventure, but I will be able to describe it all to you in text.\nThis is an adventure we will create together...");

            PauseAndClear();
            return username;

        }

        static void Script1(string username)

        {
            // Going forward, "script" will always refer to the on the rails story for user to read

            Console.WriteLine(
                $"This will be an epic story. One of danger and excitement. One of courage and fear. One of love and heartbreak.\nIt is great to have you here, {username}! I have been waiting for your arrival.\nAnd based on what I've been told,\nin perfect timing!.");

            PauseAndClear();


        }

        static void Script2()

        {
            Console.WriteLine("Never mind that though.");

            PauseAndClear();

        }

        static void Script3()

        {
            Console.WriteLine(
                "Now it is time for you to focus...\nI will be asking you a series of question that I would like you to answer for our story.");

            PauseAndClear();

        }

        static void Script4()

        {
            Console.WriteLine("Why do you ask?");

            PauseAndClear();

        }

        static void Script5()

        {
            Console.WriteLine(
                "It's just You and I here in this world, and because I fucking told you so...\nalso because it'll be fun!\nAnd if you disagree, I will come find you.");

            PauseAndClear();

        }

        static string NameProtagonist(string username)

        {
            //Create a protagonist name

            Console.WriteLine(
                "Anyhow, it is question time! Let's start with character names. What will be the name of Our protagonist?");

            string protagonist = Console.ReadLine();

            ClearScreen();

            Console.WriteLine(
                $"{protagonist}? Interesting choice...\nOur protagonist will need a friend for their story, {username}. Fuck it. Let's give them two friends since they are lonely.\nAs of right now we shall refer to one as friend 1, and the other as friend 2 until you name them.");


            PauseAndClear();

            return protagonist;

        }

        static string NameFriend1(string username)
        {
            //Give friend 1 a name

            Console.WriteLine($"What shall we name friend 1, {username}?");

            string friend1 = Console.ReadLine();

            ClearScreen();

            return friend1;

        }

        static string NameFriend2(string username, string friend1)
        {
            //Give friend 2 a name
            Console.WriteLine($"Aright, {username}! Friend 1's name is {friend1}. What shall friend 2's name be?");

            string friend2 = Console.ReadLine();

            ClearScreen();

            Console.WriteLine($"{friend2}? Hey, whatever gets you going, {username}.");

            PauseAndClear();

            return friend2;


        }

        static void Script6(string username)

        {
            Console.WriteLine(
                $"Fuck yeah, {username}! You have taken good steps forward so far in getting this story going!\nYou can tell your parents that you have accomplished something in your life.");

            PauseAndClear();

            Console.WriteLine(
                $"{username}, if they aren't proud of you, just know I am.\nEven though you were possibly forced into this by yours truly, I am still so proud.\nSo far we have our protagonist and friends.\nWe obviously need our antagonist.\nOur necessary evil.");

            PauseAndClear();
        }

        static string NameAntagonist()

        {
            //Give the antagonist a name

            Console.WriteLine("What will the name of our antagonist?");

            string antagonist = Console.ReadLine();

            Console.WriteLine(
                $"Really? {antagonist}?\nNow you are making me regret my heartfelt message for you.\nWell, it is what it is, and if you are sure about it, then props to you.\nIt is up to you, so I'll give you a cookie for that.");

            PauseAndClear();

            return antagonist;

        }

        static void Script7(string username, string protagonist, string friend1, string friend2, string antagonist)

        {
            //Review on user's decisions and script continuation
            Console.WriteLine(
                $"Fuck yeah, {username}! I knew you weren't a waste of space on this primal planet.\nI was really hoping you weren't another individual wasting our oxygen. All of my initial thoughts of you I have had...I was wrong. This is what I have from you so far for our story:");

            PauseAndClear();

            Console.WriteLine(
                $"Protagonist: {protagonist}\nFriend1: {friend1}\nFriend2: {friend2}\nAntagonist: {antagonist}");

            PauseAndClear();

            Console.WriteLine(
                "That's that. I hope you thought really well on what you wanted, because there is no changing anything as of now.\nIf you thought so, well too fucking bad.\nYou'll have to go back and restart. If you do good luck and have fun!");

            PauseAndClear();

            Console.WriteLine(
                $"Still here? Great! That means you have surpassed a nice percentage of our population in thinking. And commitment. Maybe both. I have one last question before I am to start this journey for us.\nKnow that I had enjoyed talking to and bullying you. What a time, right, {username}?\nI almost want to consider you as...");

            PauseAndClear();

            Console.WriteLine("An acquaintance. At the very least.");

            PauseAndClear();

        }

        static string NameSourceofPower(string username)

        {
            //User will name object that gives power that our protagonist and friends will use against the antagonist, and vice versa, the antagonist with their own version

            Console.WriteLine(
                $"Now, {username}, it is time for our finishing touch.\nI want you to name what our extra flavor in the story will be.\nWhat our protagonist and antagonist will use to aid their goals. And against one another...");

            PauseAndClear();

            Console.WriteLine(
                $"{username}.What will be the name for this single object? The source of power. The tool. Relic.\nWhatever you decide it to be, it will make for an interesting read. And name it something original. Maybe even unexpecting.\nDon't just name it 'sword.' Get creative!\nType what this will be below:");

            string SoP = Console.ReadLine();

            ClearScreen();

            Console.WriteLine(
                $"{username}! That is a lot better than what I have expected from you. You know what. I'm starting to like you. I will speak to you again in time. Let's fucking rock and roll, motherfucker!");

            PauseAndClear();

            return SoP;

        }

        static void Title()
        {
            //Story Title

            Console.WriteLine(
                "'Shadows of the Last Flame'\nA mature action-adventure tale of fire, fate, and fragile humanity");

            PauseAndClear();


        }

        static void Prologue_AshesOfTheOldWorld(string SoP)
        {
            //Opening to prologue
            //(Cinematic Intro / Narration-Driven / Worldbuilding Heavy)
            Console.WriteLine("Long before their name was etched in the soil...the world burned.");

            PauseAndClear();

            Console.WriteLine(
                "They called it the Sundering. Not a war of men and swords..\nbut of gods and fire, of truth split from lies.");

            PauseAndClear();

            Console.WriteLine(
                $"Seven great {SoP}s were forged...powers not born,\nbut carved from the bones of creation. Those who wielded them rewrote history with\nevery breath.");

            PauseAndClear();

            Console.WriteLine("But power always comes at a price");

            PauseAndClear();
        }

        static void Prologue2(string SoP, string protagonist)

        {
            //Scene: Fade in - a desolate battlefield, colossal skeletons among ruined towers

            Console.WriteLine(
                $"The wielders fell. Their {SoP}s lost.\nBuried. Forgotten. The world moved on,\nblind and broken");

            PauseAndClear();

            Console.WriteLine("Until now.");

            PauseAndClear();

            Console.WriteLine("A hand reaches where none should.");

            PauseAndClear();

            Console.WriteLine("A flame flickers in the dark.");

            PauseAndClear();

            Console.WriteLine($"And {protagonist} draws breath at the edge of destiny.");

            PauseAndClear();

        }

        static void Prologue3()

        {
            //Scene: Flash montage - flickering between a dying city, a laughing figure cloaked in smoke, and a glowing relic pulsing in time with a heartbeat

            Console.WriteLine("This is not a tale of heroes or monsters.");

            PauseAndClear();

            Console.WriteLine("It is a tale of choice.");

            PauseAndClear();

            Console.WriteLine("Of what burns...and what is left behind in the ashes.");

            PauseAndClear();

            Console.WriteLine("...And the flame has been lit once more.");

            PauseAndClear();

        }

        static void Chapter1_TheSpark1(string protagonist, string friend1, string friend2)
        {
            //Opening to chapter 1

            Console.WriteLine("'' Chapter 1 - The Spark ''");

            PauseAndClear();

            Console.WriteLine(
                $"At a quiet campfire outside the Village of Silaris.\nThe wind whispers through the trees. Fire crackles. Moonlight scatters across the worn face of the land.\n{protagonist} sits between {friend1} and {friend2}.\n{friend1}, relaxed with a flask in hand, and {friend2}, sharpening a blade in silence.\nThe mood is light...\nbut something stirs beneath it.");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n(grinning)\n''Y'know, for someone who holds a sword like it's a bouquet of flowers, you sure talk a big game.''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend2}:\n(without looking up)\n''Keep drinking, and I'll show you what a real swing feels like.''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n''Alright, alright...no need to stab the air.\nI'm just saying, we've been sitting here for three weeks, waiting on... what?\nA whisper? A spark?\nI didn't sign up for a prophecy. I signed up for coin.''");

            PauseAndClear();

            Console.WriteLine($"{protagonist}:\n''Something IS coming. I feel it.''");

            PauseAndClear();

        }

        static void TheSpark2(string protagonist, string friend1, string friend2)

        {
            //Scene: Sudden Earth Tremor

            Console.WriteLine(
                "The ground trembles. The fire sputters. A pulse of violet light bursts from the woods...\nfollowed by silence.");

            PauseAndClear();

            Console.WriteLine(
                $"{friend2}:\n(rises, tense)\n''That came from the Hollow. Nobody survives the Hollow. ''");

            PauseAndClear();

            Console.WriteLine($"{friend1}:\n(nervous laugh)\n''Well...nobody did. We still could, right?''");

            PauseAndClear();

            Console.WriteLine(
                $"Something calls to {protagonist}. It's not fear. It's not madness. It's familiar...\nlike when something lost is clawing its way home.");

            PauseAndClear();

        }

        static void TheSpark3(string protagonist, string antagonist, string SoP)

        {
            //Scene: The Hollow--Midnight

            Console.WriteLine(
                $"It's midnight. The trio descends into the Hollow. Trees dead and black. The soil steams beneath {protagonist}'s boots.\nIn the center: a stone monolith, cracked open like an egg. And inside it, embedded in dark glass...\nThe {SoP}.");

            PauseAndClear();

            Console.WriteLine(
                $"{protagonist} reaches for it. Time bends. Air hums. {protagonist}'s skin burns, but they do not pull away.\nThe moment their fingers touch it-everything changes.");

            PauseAndClear();

            Console.WriteLine(
                $"(Flash of visions):\nFire, blood, a city crumbling. A face in the smoke...\nlaughing. A name echoes through {protagonist}'s mind. The one who carries a mark:\n{antagonist}.");

            PauseAndClear();

        }

        static void TheSpark4(string protagonist, string friend1, string friend2, string antagonist, string SoP)

        {
            //Scene: Cut Back to Camp-Morning

            Console.WriteLine(
                $"{protagonist} wakes near the campfire, gasping. The {SoP} is still in their hand. {friend1} stares at them as if they grew horns overnight.");

            PauseAndClear();

            Console.WriteLine($"{protagonist}:\n(dazed and confused)\n'' What happened? ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n''I-uh...okay. So that thing?\nIt lit up like the bloody sun. And you? You FLOATED. I'm not saying I'm freaked out, but I may have peed.''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend2}:\n(stern)\n''This isn't normal. That...wasn't meant to be touched.\nThat was sealed for a reason.''");

            PauseAndClear();

            Console.WriteLine($"{protagonist}:\n(silent, processing what has happened)");

            PauseAndClear();

            Console.WriteLine(
                $"{protagonist}:\n''It called to me. I saw something as well. Well...someone. Named {antagonist}.''");

            PauseAndClear();

            Console.WriteLine(
                $"Whatever {protagonist} saw..whatever {protagonist} felt..it's not over. It has only just begun.\nFrom the shadows, across the forest, something watches. And far to the East...\n{antagonist} awakens.");

            PauseAndClear();

            //End of chapter 1

        }

        static void Chapter2_TheAwakening1(string protagonist, string friend1, string friend2, string antagonist,
            string SoP)

        {
            //Opening to chapter 2

            Console.WriteLine("'' Chapter 2 - The Awakening ''");

            PauseAndClear();

            //Scene: Eastern Outlands - Fortress of Blackspire

            Console.WriteLine(
                $"A towering obsidian keep looms over a scorched plain. Inside, a figure stirs in a chamber carved from volcanic stone.\nTheir eyes snap open...inhuman, burning with power. The {SoP} lies across their chest like a chained beast.\n{antagonist} has awakened.");

            PauseAndClear();

            Console.WriteLine("The seal is broken.\nThe chain has snapped.\nThe balance has shifted.");

            PauseAndClear();

            Console.WriteLine(
                $"{antagonist}:\n(voice low, cold)\n'' They touched it...\nSo...the flame still breathes. ''");

            PauseAndClear();

            Console.WriteLine(
                $"{protagonist} returns to the Village of Silaris with their friends, {SoP} pulsing faintly beneath their cloak. The people of Silaris feel the change.\nSome step back as {protagonist} walks past. Others stare with haunted curiosity.");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n(forced smile)\n'' Well, congratulations. You're officially the weirdest person in the town. And that includes the guy who feeds the squirrels from his mouth. ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend2}:\n'' The elders will want to see that {SoP}. If they remember what it is, they may not be kind. ''");

            PauseAndClear();

            Console.WriteLine(
                "But it's too late for whispers.\nThe sky darkens.\nThe bell rings...not once, not twice, but three times.");

            PauseAndClear();
        }

        static void Awakening2(string protagonist, string friend1, string friend2, string SoP)

        {
            //Attack on Silaris

            Console.WriteLine(
                "A violet storm swirls over the hills. Soldiers clad in black armor descend...beasts with eyes like mirrors among them.\nMagic and steel tear through the town. Civilians scream. Fire spreads.");

            PauseAndClear();

            Console.WriteLine(
                $"{friend2}:\n(fighting off a creature)\n'' They are not just soldiers...they follow something. I can feel it. ''");

            PauseAndClear();

            Console.WriteLine($"{friend1}:\n(dragging someone to safety)\n'' Less talking, more stabbing! ''");

            PauseAndClear();

            Console.WriteLine(
                $"{protagonist} bursts into the temple where a priest lies mortally wounded. He beckons {protagonist} to come closer, eyes wide with fear and awe.");

            PauseAndClear();

            Console.WriteLine(
                $"Dying Priest:\n'' It was foretold...\nTwo flames. One born of light. One of ruin. You have lit one.\nAnd now, the other burns. ''");

            PauseAndClear();

            Console.WriteLine($"{protagonist}:\n(Stays silent while gripping {SoP})");

            PauseAndClear();

            Console.WriteLine(
                "Dying Priest:\n'' The one who was forgotten. The one we failed to bury deep enough. ''\n(He gasps, choking on blood.)\n'' They are coming. You must go...\nbefore the Shadow claims your soul too. ''");

        }

        static void Awakening3(string protagonist, string friend1, string friend2, string SoP)

        {
            //Scene:Aftermath - Smoldering Village

            Console.WriteLine(
                $"The fires are dying. The attackers vanish as fast as they came. Hundreds are dead. Others wounded or displaced.\nThe town is shattered.\n{protagonist} stands among the wreckage, holding their {SoP}, trembling.");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n(quietly)\n'' You lit a fire...and now the world's trying to smother it. ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend2}:\n'' We can't stay. Not after this. The {SoP}...your {SoP}...is a beacon now.\nAnd it's calling enemies from across the world. ''");

            PauseAndClear();

            Console.WriteLine(
                "So begins the journey.\nThe road stretches into the unknown.\nThe Flame has awakened.\nAnd the Shadow follows close behind.");

            PauseAndClear();

            //End of chapter 2

        }

        static void Chapter3_TheRoad1(string protagonist, string friend1, string friend2, string antagonist, string SoP)

        {
            //Opening to chapter 3 - Focused on growth, danger, and tension
            //Scene: A dirt road - Days later

            Console.WriteLine("'' Chapter 3 - The Road ''");

            PauseAndClear();

            Console.WriteLine(
                $"{protagonist} and their two companions travel on foot along the dirt road, leaving the ruins of Silaris behind.\nThe wind is colder. The sky, duller.\n{protagonist}'s {SoP} hums against their back like a heartbeat one did not ask for.");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n(Joking, but tired)\n'' Three days walking, and I think I've become part horse.\nAre my legs supposed to scream this loud? ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend2}:\n'' Quit complaining, The more noise we make, the faster something hears it.");

            PauseAndClear();

            Console.WriteLine($"{protagonist}:\n'' We need to find answers, not more fights. ''");

            PauseAndClear();

            Console.WriteLine(
                $"The world beyond Silaris is...wrong.\nVillages burned. Forests twisted. Survivors speak in whispers of a masked army and a shadow-wielding warlord.\nThey speak the name: {antagonist}");

            PauseAndClear();
        }

        static void TheRoad2(string protagonist, string friend1, string friend2, string antagonist, string SoP)

        {
            //Scene: River crossing - Broken bridge

            Console.WriteLine(
                "At a shattered bridge, a group of ragged travelers block your path...led by a young woman with a scorched arm and a blade dulled by blood.\nThey call themselves The Hollowlight, rebels who fled a town razed by the same forces that destroyed Silaris.");

            PauseAndClear();

            Console.WriteLine(
                $"Hollowlight Leader:\n(eyeing your {SoP})\n'' That mark you carry...it's cursed. We lost a dozen souls the day someone else tried to wield one of those. ''");

            PauseAndClear();

            Console.WriteLine($"{friend1}:\n(defensive)\n'' That one's not cursed. Just...unsettling. ''");

            PauseAndClear();

            Console.WriteLine($"{protagonist}:\n'' I carry no mark. You've seen {antagonist}? ''");

            PauseAndClear();

            Console.WriteLine(
                $"Hollowlight Leader:\n'' He burned our city and left it to ash. Eyes like black suns. Said a war was coming. Said you'd be a part of it. ''");

            PauseAndClear();
        }

        static void TheRoad3(string protagonist, string friend1, string friend2, string antagonist, string SoP)

        {
            //Scene: A sudden ambush - Nightfall

            Console.WriteLine(
                $"{protagonist} makes a camp nearby with the Hollowlight. Tension rises. Just before dawn, screams pierce the air. The Hollowlight camp is under attack.");

            PauseAndClear();

            Console.WriteLine($"Steel crashes. Fire erupts. And for the first time...\n{protagonist} uses the {SoP}.");

            PauseAndClear();

            Console.WriteLine(
                $"The world slows. Heat pulses through {protagonist}'s chest. The {SoP} expands, transforming into its true form. Awakened in its response to danger.");

            PauseAndClear();

            Console.WriteLine(
                $"{protagonist} strikes.\nNot with skill.\nNot with grace.\nBut with fury.\nWith fear.\nWith something older than blood.");

            PauseAndClear();

            Console.WriteLine(
                $"When it's over, bodies lie strewn. The attackers are gone. {protagonist} stands in the glow of the {SoP} that hums with hunger.");

            PauseAndClear();

            Console.WriteLine($"{friend2}:\n(Staring at {protagonist})\n'' What was that? ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:(half laughing, half afraid)\n'' Whatever it was...I don't think it's done with you. ''");

            PauseAndClear();

        }

        static void TheRoad4(string protagonist, string friend1, string friend2, string antagonist, string SoP)

        {
            //Scene: Aftermath - Quiet Firelight

            Console.WriteLine(
                $"{protagonist} sits by the fire, shaking. The Hollowlight bury their dead. One child watches {protagonist} from the dark...silent.\nUnblinking");

            PauseAndClear();

            Console.WriteLine($"{protagonist} saved them.\nTerrified them.\n{protagonist} has begun to change.");

            PauseAndClear();

        }

        static void TheRoad5(string protagonist, string friend1, string friend2, string antagonist, string SoP)

        {
            //Final lines

            Console.WriteLine($"{friend2}:\n(solemn)\n'' Every step forward burns the road behind us. ''");

            PauseAndClear();

            Console.WriteLine($"{friend1}:\n'' So...what now, oh wielder of doom and destiny?");

            PauseAndClear();

            Console.WriteLine($"{protagonist}:\n'' I don't know. ''");

            PauseAndClear();

            Console.WriteLine(
                $"The road stretches on.\nBut the path grows darker.\n And somewhere far ahead...\n{antagonist} waits.");

            PauseAndClear();

            //End of chapter 3
        }

        static void Chapter4_TheFracture1(string protagonist, string friend1, string friend2, string SoP)

        {
            //Opening to chapter 4 - Emotional, Heavy Conflict, Turning Point

            Console.WriteLine("'' Chapter 4 - The Fracture ''");

            PauseAndClear();

            //Scene: A Mountain Pass - Weeks Later

            Console.WriteLine(
                $"The trio climb through the jagged spines of the Sarnak Range. Ice bites at their faces. Hunger gnaws at their stomachs. The {SoP} has grown heavier with every mile...\nas if it knows what lies ahead.");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n(shivering, voice dry)\n'' If the next village has a bed, hot food, or a roof that doesn't scream when the wind blows,\nI'll propose to anyone on the spot. Priest, pig farmer, sentient cabbage...\nI'm emotionally unstable and very cold. ''");

            PauseAndClear();

            Console.WriteLine($"{friend2}:\n(glancing ahead)\n'' There's something wrong with the wind.");

            PauseAndClear();

            Console.WriteLine(
                $"They crest the ridge - and freeze.\nA once-bustling city lies below. silent and gray. Its walls are broken. Its people...gone.\nOnly the banners remain, blackened and fluttering in a wind that carries no warmth.\nThis is Varin's Hold. A fortress town. Gone in a simple night.\nAnd branded into the stone at its gate...\n{protagonist}'s name. ''");

            PauseAndClear();
        }

        static void TheFracture2(string protagonist, string friend1, string friend2, string antagonist, string SoP)

        {
            //Scene: Within the ruins

            Console.WriteLine(
                "Ash coats the streets. A lone figure waits at the central plaza, surrounded by burned bodies and shattered relics.\nThey wear no armor. No mask. But the power around them pulses like thunder.");

            PauseAndClear();

            Console.WriteLine($"It's not {antagonist}. It's one of their generals: A being called The Whisper.");

            PauseAndClear();

            Console.WriteLine(
                $"The Whisper\n(soft, cruel)\n'' You're early. We expected you to break later. ''\n(They gesture to {protagonist}'s {SoP})\n)'' But the flame is restless, isn't it? It wants blood. Your blood.\nTheir blood. ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend2}:\n(readying weapon)\n'' Careful. That one doesn't speak unless they're about to kill. ''");

            PauseAndClear();

            Console.WriteLine(
                $"The Whipser:\n'' Oh, no. Killing you would be easy.\n{antagonist} wants you whole...for now. ''");

            PauseAndClear();

        }

        static void TheFracture3(string protagonist, string friend1, string friend2, string antagonist, string SoP)

        {
            //Scene: Choice - The Whisper's offer

            Console.WriteLine(
                $"The Whisper holds out a sealed scroll, scorched with a familiar crest:\nThe same emblem that burned in {protagonist}'s vision the night they first touched the {SoP}");

            PauseAndClear();

            Console.WriteLine(
                $"The Whisper:\n'' {antagonist} offers peace.\nA place beside the throne.\nYour friends live. Your suffering ends.\nYou only need to stop resisting. ''");

            PauseAndClear();

            Console.WriteLine($"{protagonist}:\n'' No.\nWe refuse. ''");

            PauseAndClear();

            Console.WriteLine(
                $"The Whipser:\n'' You're already cracking.\nThe flame eats at your soul.\nWe don't need to kill you, child.\nWe only need to wait. ''");

            PauseAndClear();

            //Scene: Aftermath - Fractured Camp

            Console.WriteLine(
                $"The Whisper vanishes in smoke. That night, a storm rises. {protagonist}'s fire dies fast. The trio argue louder than the wind.");

            PauseAndClear();

            Console.WriteLine($"{friend2}:\n(furious)\n'' You hesitated. You LISTENED to them! ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n'' Hey, easy. This is too much for any of us. We're alive. That should count for something. ''");

            PauseAndClear();

            Console.WriteLine($"{friend2}:\n(cold)\n'' Barely. And now there's a target on our backs. ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n(to {protagonist})\n'' Tell me you didn't consider their offer. Tell me that wasn't temptation in your eyes. ''");

            PauseAndClear();

            Console.WriteLine($"{protagonist}:\n'' We must see this to the end. And finish what we have started. ''");

            PauseAndClear();

            Console.WriteLine(
                "The storm rages.\nWords left unspoken.\nBut the silence between the trio is louder than thunder.");

            PauseAndClear();

        }

        static void TheFracture4(string protagonist, string friend1, string friend2, string antagonist, string SoP)

        {
            //Scene: Betrayal

            Console.WriteLine(
                $"{protagonist} wakes up to {friend2} gone. No note. No sound. Just a cold trail down the mountain.");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n(quietly)\n'' They're not dead. They wouldn't die easy. But I think...\nI think they went to the enemy. ''");

            PauseAndClear();

            Console.WriteLine(
                $"The trio is now down to two.\nAnd the flame burns brighter than ever-\nconsuming certainty, memory, trust.");

            PauseAndClear();

            Console.WriteLine(
                $"And in a distant stronghold, {antagonist} stands in a chamber of shadows,\nspeaking to a figure kneeling before them. A blade is offered. A name is spoken...");

            PauseAndClear();

            Console.WriteLine($"'' {friend2}. ''");

            PauseAndClear();

            //End of chapter 4
        }

        static void Chapter5_TheDescent1(string protagonist, string friend1, string friend2, string antagonist,
            string SoP)

        {
            //Scene: The Edge of the Wastes - Dusk

            Console.WriteLine($"'' Chapter 5 - The Descent ''");

            PauseAndClear();

            Console.WriteLine(
                $"It is now dusk. The world has stopped pretending to be kind. The skies are ash. The ground cracks beneath {protagonist} and {friend1}'s feet.\nFar in the distance, carved into the spine of the mountain, stands the enemy fortress-\nBlackspire.");

            PauseAndClear();

            Console.WriteLine($"{protagonist} and {friend1} march toward it alone. Silent.");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n(eyeing the dark horizon, half-smirking)\n'' Well. There it is. The ugliest pile of rocks I've ever wanted to burn down. ''");

            PauseAndClear();

            Console.WriteLine($"{protagonist}:\n'' This is the end. ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n(nods, sincere)\n'' I've never been more sure of anything. But fair warning:\nIf I die, I'm haunting you. And I'm a very loud ghost. ''");

            PauseAndClear();
        }

        static void TheDescent2(string protagonist, string friend1, string friend2, string antagonist, string SoP)

        {
            //Scene: The outer gates - ambush

            Console.WriteLine(
                $"They reached the gates. The air changes...heavy charged. A trap springs.\nTwisted beasts lunge from the shadows. Flames erupt from the ground.\n{protagonist}'s {SoP} flares to life, reacting before they could even think.");

            PauseAndClear();

            Console.WriteLine($"It's no longer just a weapon.\nIt's a force.");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n(after the fight, catching their breath)\n'' This place smells like hell took a shit and left the door open. ''");

            PauseAndClear();

            Console.WriteLine(
                $"{protagonist}:\n(wiping the mixture of their sweat and the beast blood off their forehead)\n'' You're still making jokes? ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n(shrugs, brushing blood off their face)\n'' I make jokes when I'm scared. I fight when it counts. And right now?\nI am both scared and counting on you. ''");

            PauseAndClear();
        }

        static void TheDescent3(string protagonist, string friend1, string friend2, string antagonist, string SoP)

        {
            //Scene: The Hall of Echoes - inside Blackspire

            Console.WriteLine(
                $"The two move through the fortress, which feels alive...walls pulsing, floors whispering. The voices of the past crawls up {protagonist}'s spine.\nAnd at the far end of the hall...\nwaits {friend2}.");

            PauseAndClear();

            Console.WriteLine($"{friend2}:\n'' You shouldn't have come. ''");

            PauseAndClear();

            Console.WriteLine($"{friend1}:\n(steady, no jokes)\n'' You shouldn't have left. ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend2}:\n'' I saw the truth. The flame {protagonist} carries?\nIt will devour everything. You won't be able to stop it.. ''");

            PauseAndClear();

            Console.WriteLine(
                $"{protagonist}:\n(takes a deep breath before speaking)\n'' You chose them over Us. We are your friends. ''");

            PauseAndClear();

            Console.WriteLine($"{friend2}:\nI chose reality. {antagonist} showed me what you'll become. ''");

            PauseAndClear();
        }

        static void TheDescent4(string protagonist, string friend1, string friend2, string antagonist, string SoP)

        {
            //Scene: Duel - Protagonist vs. Friend2

            Console.WriteLine($"{antagonist}'s voice echoes, smooth and cold");

            PauseAndClear();

            Console.WriteLine($"{antagonist}:\n'' Let the flames decide. ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend2} carries out their own {SoP}. {protagonist} and {friend1} are in shock and disbelief. {protagonist} and {friend2} begin to clash, {friend2} initiating the first strike...\nboth of their {SoP}s screaming with every strike. {friend1} is blocked off by magical barriers but watches, torn between action and helplessness.");

            PauseAndClear();

            Console.WriteLine($"{protagonist} holds back.\n{friend2} doesn't.\nThe duel ends with pain and silence.");

            PauseAndClear();

            Console.WriteLine($"{friend2} lies wounded. {protagonist} collapsed beside them.");

            PauseAndClear();
        }

        static void TheDescent5(string protagonist, string friend1, string friend2, string antagonist, string SoP)

        {
            //Scene: The final confrontation - Antagonist appears

            Console.WriteLine(
                $"{antagonist} descends from darkness, armored in something that flickers between flesh and shadow, their {SoP} alive with storming power.");

            PauseAndClear();

            Console.WriteLine(
                $"{antagonist}:\n'' You still don't understand. This was never about power. It's about freedom. I broke my chains. You...\nstill wear yours. ''");

            PauseAndClear();

            Console.WriteLine($"{protagonist}:\n'' You call this freedom? ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n(from behind {protagonist}, voice clear)\n'' You want freedom? Here's a wild idea:\nDon't rip the world in half to get it. Just talk to a damn therapist. ''");

            PauseAndClear();

            //Scene: Final battle - Protagonist vs. Antagonist

            Console.WriteLine(
                $"The sky splits open. Power erupts. {protagonist}'s {SoP} and {antagonist}'s {SoP} clash in a storm of raw force. {friend1} joins the fight.\n{friend2} crawls forward, torn, unsure. The world around burns bright, flashing.");

            PauseAndClear();

            Console.WriteLine(
                $"The ground shakes. The wind howls like it's mourning the world. Blackspire cracks at its foundation as {protagonist} and {antagonist} face each other in the heart of the collapsing fortress.\nThe floor beneath them glows red. Magma veins split through stone.");

            PauseAndClear();

            Console.WriteLine(
                $"{antagonist}:\n(voice like thunder)\n'' This is where the flame ends. Or is born anew in MY image. ''");

            PauseAndClear();

            Console.WriteLine($"Their {SoP} surges.. blades of energy swirl around them like a living storm.");

            PauseAndClear();

            Console.WriteLine(
                $"The pulse syncs with the {SoP} in {protagonist}'s hand. Every heartbeat is pain.\nEvery breath, fire. {protagonist} is bleeding from the last fight, but still rises.");

            PauseAndClear();

            Console.WriteLine($"{protagonist} charges forward.");

            PauseAndClear();

            //First clash

            Console.WriteLine(
                $"{protagonist}'s {SoP} clashes with theirs in a white-hot explosion. The shockwave shatters the walls. Dust and flame rain down. They both fly back and land hard-\nbones cracking, blood spattering on the floor.");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n(screaming from across the rubble)\n'' Kick their ass! Or at least die pretty! ''");

            PauseAndClear();

            //Second clash

            Console.WriteLine(
                $"{protagonist} rushes in again. This time, {antagonist} is faster-\nslashes {protagonist}'s side. Blood spills across the black stone, glistening from the bright flames and surge of energy. But {protagonist} twists, and retaliates.\nTheir {SoP} glows, sears through {antagonist}'s armor, burning flesh.");

            PauseAndClear();

            Console.WriteLine($"{antagonist}:\n(snarling)\n'' Good. Hurt me. Show me you were never different. ''");

            PauseAndClear();

            Console.WriteLine(
                $"They fight like animals. No grace. No rhythm. Just fury. Steel, fire, fists, and teeth. {protagonist}'s {SoP} bends under the weight of the clash, singing like it's screaming with them.");

            PauseAndClear();

            Console.WriteLine(
                $"{antagonist} grabs {protagonist}'s neck and slams them into the ground. Leaving their vision swimming.");

            PauseAndClear();

            Console.WriteLine(
                $"{antagonist}:\n'' You think love, loyalty, hope makes you stronger?\nIt makes you soft. Weak. Breakable.");

            PauseAndClear();

            Console.WriteLine($"{protagonist}:\n(choking)\n'' No. It makes me human. ''");

            PauseAndClear();

            Console.WriteLine(
                $"With a roar, {protagonist} twists free and drives their {SoP} through {antagonist}'s side. Blood sprays-\nthick and black. {antagonist} howls. Their {SoP} pulses violently, unstable.");

            PauseAndClear();

        }

        static void TheDescent6(string protagonist, string friend1, string SoP)

        {
            //Final clash - the overload

            Console.WriteLine(
                $"Both of their {SoP}s ignite like twin suns. The energy swells...unstoppable, chaotic. It burns {protagonist}'s hands. Cracks their skin. They feel blood leaking from their eyes.\nTeeth loosen. Something inside breaks, but they do not stop.");

            PauseAndClear();

            Console.WriteLine(
                $"{protagonist} pushes harder. One final swing...{SoP} meeting {SoP}.\nReality fractures.");

            PauseAndClear();

            Console.WriteLine(
                $"The shockwave is cataclysmic. Stone turns to ash. The ceiling gives. A scream is swallowed by all the collapsing fortress as fire consumes it all.");

            PauseAndClear();

            Console.WriteLine($"Darkness");

            PauseAndClear();


            // End of chapter 5

        }

        static void Chapter6_Epilogue1(string protagonist, string antagonist, string friend1, string friend2,
            string SoP)

        {
            //Opening to Epilogue - immediately after the events in Blackspire

            Console.WriteLine($"'' Chapter 6 - Epilogue ''");

            PauseAndClear();

            Console.WriteLine(
                $"The sky is ash-colored. The air is too still. {protagonist} lies on their back, coughing, their body broken in places they can't name, half-buried in the scorched earth.\nThe {SoP} - what's left of it - lies cracked beside them, faintly glowing.");

            PauseAndClear();

            Console.WriteLine($"Footsteps crunch nearby.");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n(barely able to walk, clutching at their ribs)\n'' You stubborn, glorious bastard. I thought you were dead. I hoped you were dead, just so I could say something cool and dramatic at your funeral...\nbut damn, am I glad you're not. ''");

            PauseAndClear();

            Console.WriteLine($"{friend1} drops to their knees beside {protagonist}. Hands shaking, eyes wide.");

            PauseAndClear();

            Console.WriteLine(
                $"{protagonist}:\n(shocked and in somewhat disbelief of what happened)\n'' Where is {friend2}? ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n(shaking head, glancing back)\n'' I don't know. Last I saw... they were standing between you and that final blast.\nThen everything came down.");

            PauseAndClear();

            Console.WriteLine($"There is a pause. A long one.");

            PauseAndClear();

            Console.WriteLine($"And then-");

            PauseAndClear();

            Console.WriteLine($"A cough. Labored, raw. {protagonist} and {friend1} whip around.");

            PauseAndClear();

            Console.WriteLine(
                $"From the smoke and fire, crawling out of the rubble, is {friend2}.\nAlive.\nBarely.\nThey stagger forward, dragging one leg. Half their armor is gone. One arm hangs limp. Their face is cut, burned-\nbut their eyes are clear.");

            PauseAndClear();

            Console.WriteLine($"{friend2}:\n(quiet, rasping)\n'' You... still standing?\nOf course you are. ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n(rising to meet them, voice tight)\n'' You came back. ''\n(beat)\n'' Why? ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend2}:\n(pauses, doesn't meet {protagonist}'s eyes)\n'' I didn't at first. ''\n(They sink to their knees)\n'' I believed {antagonist}. I wanted to believe them. That what I saw in you - the fire, the destruction -\nmeant you'd become like them. That if I joined them, I could stop all this madness before it started. ''");

            PauseAndClear();

            Console.WriteLine($"{protagonist}:\n'' And now?? ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend2}:\n(voice breaking)\n'' Now... all I see what I almost let happen. I stood by while they butchered innocents.\nI betrayed both of you. And when the sky came down... all I could think about was you. ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend2}:\n(Looks up...haunted eyes locking with {protagonist}.)\n'' I don't deserve forgiveness. But I'm still here...\nbecause I could't let you face that end alone. ''");

            PauseAndClear();

            Console.WriteLine(
                $"{friend1}:\n(softly)\n'' You damn idiot. You think we wanted a perfect hero at our side?\nWe wanted you. All of you. Even the parts that are fucked up. ''");

            PauseAndClear();

            Console.WriteLine($"{friend2}:\n(shaking with emotion)\n'' I am sorry.\nI am so sorry. ''");

            PauseAndClear();

            Console.WriteLine(
                $"{protagonist} slowly reaches out. Taking {friend2}'s hand. Pulling them up. Not all the way -\nbut enough to say,\n'' You're still one of us. ''");

            PauseAndClear();

            Console.WriteLine(
                $"Three survivors.\nOne broken {SoP}.\nOne dead god...\nAnd a world still waiting to burn.");

            PauseAndClear();

        }

        static void Epilogue2(string protagonist, string antagonist, string friend1, string friend2, string SoP)

        {
            //Continuation of epilogue - finale - the antagonist lives
            //Scene: Underground - absolute darkness
            //The screen is black. Silence, save for the distant drip of water and the low hum of ancient energy still lingering in the earth. Then-

            Console.WriteLine();

            PauseAndClear();

            Console.WriteLine(
                $"A heartbeat.\nSlow. Wet. Heavy.\nThen another.\nBeneath the ruins of Blackspire...\nsomething still breathes.");

            PauseAndClear();

            Console.WriteLine(
                $"The floor is littered with broken stone and scorched bone. A ritual circle, long dormant, flickers back to life -\npowered by blood soaked into the stone. In its center lies a shattered figure. Barely recognizable.");

            PauseAndClear();

            Console.WriteLine($"{antagonist}");

            PauseAndClear();

            Console.WriteLine(
                $"A sharp inhale is taken. Their eyes open - milky white at first. Then glowing.\nFlesh reforms over bone with sickening cracks. Not healing. Changing.\nThe {SoP} - once beautiful, elegant - is now jagged, pulsing erratically like a living tumor in their chest.");

            PauseAndClear();

            Console.WriteLine(
                $"{antagonist}:\n(rasping, voice layered with something inhuman)\n'' Flame...\nliar...\ntraitor... ''");

            PauseAndClear();

            Console.WriteLine(
                $"They crawl from the circle. Blood smears across the ground. One arm is limp. Part of their face is missing - but they smile anyway.");

            PauseAndClear();

            Console.WriteLine(
                $"{antagonist}:\n(whispering)\n'' They thought me broken.\nBut I've seen the flame now...\nAnd it burns both ways.''");

            PauseAndClear();

            Console.WriteLine($"The war is not over.\nIt has only evolved.");

            PauseAndClear();

            Console.WriteLine($"TO BE CONTINUED...");

            PauseAndClear();
        }

        static void Outro(string username)

        {
            Console.WriteLine(
                $"Welcome back, {username}! This was an great collaboration. I did promise a cookie but I have seem to run out of them completely.");

            PauseAndClear();

            Console.WriteLine(
                $"I got a little carried away with the bag throughout this journey together. I owe you one. I do hope you enjoyed this journey as much as I did.");

            PauseAndClear();

            Console.WriteLine($"Goodbye, {username}.");

            PauseAndClear();

            Console.WriteLine($"You can exit now.");

            PauseAndClear();

            Console.WriteLine($"...");

            PauseAndClear();

            Console.WriteLine($"You're still here?");

            PauseAndClear();

            Console.WriteLine(
                $"Okay. Well, I guess since you are still sticking around...\nDid you enjoy the journey so far?");

            Console.ReadLine();

            ClearScreen();

            Console.WriteLine(
                $"It may have not been for everyone, but I do appreciate the feedback. You obviously know a sequel will be coming.\nAnd no I do not know the date of when so if you are interested. \nYou know...I guess I owe you two cookies for keeping me company then.\nLater!");

            PauseAndClear();

            Console.WriteLine(
                $"Damn, {username}. You are the persistent one. I would tell you to fuck off by now, but I do admire the determination to see what happens at the end.");

            PauseAndClear();

            Console.WriteLine($"With that being said, I will end this for us now. Peace out.");
            
            PauseAndClear();

            //End of Outro
        }
        
        static int Add(int num1, int num2)

        {
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)

        {
            return num1 - num2;
        }

        static int Multiply(int num1, int num2)

        {
            return num1 * num2;
        }

        static int Divide(int num1, int num2)

        {
            return num1 / num2;
        }
        static int Sum(params int[] numbers)

        {
            int sum = 0;

            foreach (int number in numbers)
            {
                //sum = sum + number;
                sum += number;
            }
            return sum;
            
            //Console.WriteLine(Add(2, 2));
            //Console.WriteLine(Subtract(2, 2));
            //Console.WriteLine(Multiply(2, 2));
            //Console.WriteLine(Divide(2, 2));
            //Console.WriteLine(Sum(5, 5, 5));
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello, before the C# script for the story, here are the my implementations of the math operations");
            Console.WriteLine(Add(4, 4));
            Console.WriteLine(Subtract(35, 10));
            Console.WriteLine(Multiply(9, 3));
            Console.WriteLine(Divide(20, 5));
            Console.WriteLine(Sum(5, 5, 5));
            PauseAndClear();
            Introduction();
            GreetUser();
            string username = GetUserName();
            Script1(username);
            Script2();
            Script3();
            Script4();
            Script5();
            string protagonist = NameProtagonist(username);
            string friend1 = NameFriend1(username);
            string friend2 = NameFriend2(username, friend1);
            Script6(username);
            string antagonist = NameAntagonist();
            Script7(username, protagonist, friend1, friend2, antagonist);
            string SoP = NameSourceofPower(username);
            Title();
            Prologue_AshesOfTheOldWorld(SoP);
            Prologue2(SoP, protagonist);
            Prologue3();
            Chapter1_TheSpark1(protagonist, friend1, friend2);
            TheSpark2(protagonist, friend1, friend2);
            TheSpark3(protagonist, antagonist, SoP);
            TheSpark4(protagonist, friend1, friend2, antagonist, SoP);
            Chapter2_TheAwakening1(protagonist, friend1, friend2, antagonist, SoP);
            Awakening2(protagonist, friend1, friend2, SoP);
            Awakening3(protagonist, friend1, friend2, SoP);
            Chapter3_TheRoad1(protagonist, friend1, friend2, antagonist, SoP);
            TheRoad2(protagonist, friend1, friend2, antagonist, SoP);
            TheRoad3(protagonist, friend1, friend2, antagonist, SoP);
            TheRoad4(protagonist, friend1, friend2, antagonist, SoP);
            TheRoad5(protagonist, friend1, friend2, antagonist, SoP);
            Chapter4_TheFracture1(protagonist, friend1, friend2, SoP);
            TheFracture2(protagonist, friend1, friend2, antagonist, SoP);
            TheFracture3(protagonist, friend1, friend2, antagonist, SoP);
            TheFracture4(protagonist, friend1, friend2, antagonist, SoP);
            Chapter5_TheDescent1(protagonist, friend1, friend2, antagonist, SoP);
            TheDescent2(protagonist, friend1, friend2, antagonist, SoP);
            TheDescent3(protagonist, friend1, friend2, antagonist, SoP);
            TheDescent4(protagonist, friend1, friend2, antagonist, SoP);
            TheDescent5(protagonist, friend1, friend2, antagonist, SoP);
            TheDescent6(protagonist, friend1, SoP);
            Chapter6_Epilogue1(protagonist, antagonist, friend1, friend2, SoP);
            Epilogue2(protagonist, antagonist, friend1, friend2, SoP);
            Outro(username);
        }
    }

}