Planet sun;
void setup()
{
  size(1200,800);
  sun=new Planet(100,1,1);
   sun.spawnMoons(4);
}
void draw()
{
 
  background(0);
  
  translate(width/2,height/2);
  sun.show();
  sun.orbit();
 
}
