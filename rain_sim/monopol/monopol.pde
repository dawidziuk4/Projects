Pole[] pole=new Pole[40];
void setup()
{
  size(880,880);
  
  for(int i=0;i<40;i++){
    if(i<11)
  pole[i] = new Pole(i*80,0);
   else if(i>10&&i<21)
   pole[i] = new Pole(width-80,(i-10)*80);
    else if(i>20&&i<31)
   pole[i] = new Pole((30-i)*80,height-80);
   else 
    pole[i] = new Pole(0,height-80-(80*(i-30)));
  }
}
void draw()
{
  background(255,210,210);
  for(int i=0;i<40;i++)
  pole[i].show(i);
}
