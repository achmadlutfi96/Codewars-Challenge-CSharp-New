using System;

public class Guesser
{
    private int number;
    private int lives;

    public Guesser(int number, int lives)
    {
        this.number = number;
        this.lives = lives;
    }

    public bool Guess(int n)
    {
        if(this.lives == 0){
            throw new Exception("Expected error thrown");
        }
        if(n == this.number){
            return true;
        }else{
            this.lives--;
            return false;
        }
    }
}