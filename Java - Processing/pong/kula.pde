class Kula
{
  float x=width/2;
  float y=height/2;
  float xspeed=10;
  float yspeed=4;
  
  
  
  void show(){
    fill(255);
    ellipse(x,y,20,20);
  }
  void move(){
    x=x+xspeed;
    y=y+yspeed;
  }
  void edges(){
    if(y<10 || y>height-10)
      yspeed=yspeed*(-1);
    if(x>width)
      winP2();
    if(x<0)
      winP1();
  }
  void winP1(){
    x=width/2;
    y=height/2;
    
   
    yspeed=random(-8,8)*(-1);
    xspeed=random(5,12)*(-1);
    
     p1s++;
  }
  void winP2(){
    x=width/2;
    y=height/2;
    
    yspeed=random(-8,8);
    xspeed=random(5,12);
    
     p2s++;
  }
  void checkPaddle(Player p,float dir)
  {
    if(p==p1)
    {
      if((x+20<width)&&(x+20>width-p.szer)&&(y>p.y-p.h/2)&&(y<p.y+p.h/2))
      {
        xspeed=xspeed*(-1);
      }
    }
    //(y>y-p.h/2)
    if(p==p2)
    {
      if((x-20<p.szer)&&(x-20>0)&&(y>p.y-p.h/2)&&(y<p.y+p.h/2))
      {
        xspeed=xspeed*(-1);
      }
    }
    
  }
  
}
