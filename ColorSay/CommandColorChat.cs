using System;
using UnityEngine;
using System.Collections.Generic;
using Rocket.Unturned;
using Rocket.Unturned.Player;
using Rocket.Unturned.Commands;

namespace ColorSay
{
    public class CommandColorSay : IRocketCommand
    {
        public bool RunFromConsole
        {
            get { return false; }
        }

        public string Name
        {
            get { return "csay"; }
        }

        public void Execute(RocketPlayer caller, string[] command)
        {
            if (command.Length == 0)
            {
                RocketChat.Say(caller, "/csay (color) (message) - List of colors:", Color.yellow);
                RocketChat.Say(caller, "black, blue, clear, cyan, gray, green, grey, magenta, red, white, yellow, debug.", Color.yellow);
                return;
            }
            string color = command[0].ToLower(), message = "";
            int i = 0;
            foreach (string space in command)
            {
                if (i != 0)
                {
                    message += space + " ";
                }
                i++;
            }
            switch (color)
            {
                case "black":
                    RocketChat.Say(message, Color.black);
                    break;
                case "blue":
                    RocketChat.Say(message, Color.blue);
                    break;
                case "clear":
                    RocketChat.Say(message, Color.clear);
                    break;
                case "cyan":
                    RocketChat.Say(message, Color.cyan);
                    break;
                case "gray":
                    RocketChat.Say(message, Color.gray);
                    break;
                case "green":
                    RocketChat.Say(message, Color.green);
                    break;
                case "grey":
                    RocketChat.Say(message, Color.grey);
                    break;
                case "magenta":
                    RocketChat.Say(message, Color.magenta);
                    break;
                case "red":
                    RocketChat.Say(message, Color.red);
                    break;
                case "white":
                    RocketChat.Say(message, Color.white);
                    break;
                case "yellow":
                    RocketChat.Say(message, Color.yellow);
                    break;
                case "debug":
                    RocketChat.Say(message, Color.Lerp(Color.blue, Color.red, 255));
                    break;
                default:
                    RocketChat.Say(caller, "Error: Color: " + color + " is not available.", Color.red);
                    break;
            }
        }
    

        public string Help
        {
            get { return "/csay (color) (message) - Say a message in a specific color!"; }
        }
    }
}
