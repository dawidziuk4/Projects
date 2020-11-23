Kula kula;
Player p1;
Player p2;
int p1s=0;
int p2s=0;
void setup(){
  size(1200,800);
  kula=new Kula();
  p1=new Player(true);
  p2=new Player(false);
}
void draw(){
  background(0);
  kula.show();
  kula.move();
  kula.edges();
  p1.show();
  p2.show();
  
  kula.checkPaddle(p1,kula.xspeed);
  kula.checkPaddle(p2,kula.xspeed);
  
  textSize(32);
  text(p1s,15,35);
  text(p2s,width-47,35);
    
}
void keyPressed()
{
  if(key=='w')
  {  
    p1.move(-1);
  }
  if(key=='s')
  {  
    p1.move(1);
  }
  if(key=='e')
  {  
    p2.move(-1);
  }
  if(key=='d')
  {  
    p2.move(1);
  }
}
