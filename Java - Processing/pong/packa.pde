class Player{
 float x;
 float y;
 float h=150;
 float szer=30;
 float speed=25;
 
  Player(boolean p){
  if(p==true)//prawy
    x=width-szer; 
  else
    x=szer;    
    
    y=height/2;
  }
  void show()
  {
    rectMode(CENTER);
    rect(x,y,szer,h);   
  }
  void move(int dir)
  {
    y=y+speed*dir;
    y=constrain(y,h/2,height-h/2);
  }
  
}
