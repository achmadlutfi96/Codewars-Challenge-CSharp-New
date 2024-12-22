namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public bool WillYou(bool young, bool beautiful, bool loved){
          //coding and coding..
          
          return !((young && beautiful) == loved);

          // Alternative
          // return loved != (young && beautiful);
        }
    }
}