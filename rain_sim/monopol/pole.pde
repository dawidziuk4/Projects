class Pole{
  float size=width/10;
 String nazwa;
 int price;
 float x;
 float y;
 
   Pole(float a, float b)
   {
      x=a;
      y=b;
   }
   
  void show(int i)
  {
    fill(5*i,5*i,100);
   // rectMode(CENTER);
    rect(x,y,size,size);
    textSize(32);
    fill(255,0,0);
    text(i+1,x+20,y+20);
    
    pushMatrix();
    rotate(PI/4);
    fill(200,0,255);
    textSize(62);
    text("MONOPOLY",440,60);
    popMatrix();
  }
};
