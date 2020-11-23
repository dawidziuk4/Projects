class drop
{
    float x=random(width);;
    float y=random(-2000,0);
    float thick;
    float z=random(0,20);
    float leng=map(z,0,20,10,20);
    float grav=0.1;
        float ySpeed=map(z,0,20,5,10);
    void fall()
    {
      
      if(y>height){
        y=random(-400,0);
        ySpeed=random(2,5);
      }
      y=y+ySpeed;
      ySpeed+=grav;
      
    }
    void render()
    {
      thick=map(z,0,20,1,3);
      strokeWeight(thick);
      stroke(205,100,240);
      line(x,y,x,y+leng);
    }
}
