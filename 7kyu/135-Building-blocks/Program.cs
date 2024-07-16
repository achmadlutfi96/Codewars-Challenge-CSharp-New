class Block
{
  // Gooc Luck!
  private int _width;
  private int _length;
  private int _height;
  
  public Block(int[] arr){
    _width = arr[0];
    _length = arr[1];
    _height = arr[2];
  }

  public int GetWidth(){
    return _width;
  } 

  public int GetLength(){
    return _length;
  }

  public int GetHeight(){
    return _height;
  }

  public int GetVolume(){
    return _width * _length * _height;
  }

  public int GetSurfaceArea(){
    return 2*((_width * _length) + (_length*_height)+(_height *_width));
  }
}