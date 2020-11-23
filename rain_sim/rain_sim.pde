
 drop[] d=new drop[2000];
  
void setup(){
  size(1200,800);
 for(int i=0;i<d.length;i++)
   d[i]=new drop();
}

void draw(){
  
  background(250,220,220);
  
 for(int i=0;i<d.length;i++)
{
  
 
  d[i].fall();
  d[i].render(); 
}}
