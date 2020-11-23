class Planet
{
  float angle;
  float s;
  int l;
  float orbitSpeed;
  float d;
  float force;
  Planet moons[];
  Planet(float size,float distance,int level)
  {
    s=size;
    d=distance;
    orbitSpeed=random(-0.03,0.03);
    l=level;
    
   // force=(0.001*s)/(d*d);
  }
  
  void show()
  {
    
    
    pushMatrix();
    rotate(angle);
    translate(d,0);
   // fill(255,100);
    //float z=20+angle*200;
    float y=50+angle*50;
    float x=50+angle*100;
    println(l);
    if(l==2)
    {
      x=222;y=222;
    }
     fill(100,x,y);
    strokeWeight(1);
    ellipse(0,0,s,s);
   if(moons!=null)
    {
      for(int i=0 ; i<moons.length;i++)
         moons[i].show();
    }
    popMatrix();
  }
  void spawnMoons(int total)
  {
    
      moons=new Planet[total];
           for(int i=0;i<moons.length;i++)
           {         
           float dist=random(s,s*3.5);
           float promien=s*random(0.2,0.4);
           moons[i]=new Planet(promien,(dist+s)/(l*1.3),l+1);
           if(l<2)
            moons[i].spawnMoons(3);
           }
  }
  void orbit()
  {
    
    angle=(angle+orbitSpeed);
   
    
    if(moons!=null)
    for(int i=0;i<moons.length;i++)
    {
     moons[i].orbit();
     // translate(-force,0);
    }
    
  }
  
}
