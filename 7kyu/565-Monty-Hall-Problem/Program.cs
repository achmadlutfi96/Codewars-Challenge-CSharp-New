using System;
using System.Linq;

public class Kata
{
    public static int MontyHall(int correctDoor, int[] participants)
    {
        int totalParticipants = participants.Length;
        int winsAfterSwitching = 0;
        foreach (int guess in participants)
        {
            // The host opens a door that doesn't have the prize and is not the player's choice. 
            int doorOpenedByHost = Enumerable.Range(1, 3).First(d => d != correctDoor && d != guess);
            // The player switches to the remaining unopened door. 
            int switchedGuess = Enumerable.Range(1, 3).First(d => d != guess && d != doorOpenedByHost);
            // Check if the switched guess is the prize door. 
            if (switchedGuess == correctDoor)
            {
                winsAfterSwitching++;
            }
        }

        // Calculate the win percentage 
        double winPercentage = ((double)winsAfterSwitching / totalParticipants) * 100;

        // Return the rounded win percentage as an integer 
        return (int)Math.Round(winPercentage);

        // Alternative
        // return (int)Math.Round(participants.Count(x => x != correctDoor) * 100.0 / participants.Length);
    }
}