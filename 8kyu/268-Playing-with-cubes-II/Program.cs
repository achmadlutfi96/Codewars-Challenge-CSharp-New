using System;
public class Cube
{
  private int Side;
  
  //This cube needs your help. 
  //Define a constructor which takes one integer and assignes its value to 'Side'
  public Cube(int side){
    this.Side = Math.Abs(side);
  }

  public Cube(){
    this.Side = 0;
  }
  
  public int GetSide()
  {
    return this.Side;
  }
  
  public void SetSide(int s)
  {
    this.Side = Math.Abs(s);
  }
}