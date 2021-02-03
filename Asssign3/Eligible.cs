using System;
using System.Collections.Generic;
using System.Text;

namespace Asssign3
{
    public class Eligible
    {
        private int maths;
        private int physics;
        private int chemistry;
        public Eligible(int physics,int chemistry,int maths)
        {
            this.physics = physics;
            this.chemistry = chemistry;
            this.maths = maths;
        }
        public void eligibility()
        {
            int total;
            total = maths + physics + chemistry;
            if(maths>=65 && physics>=55 && chemistry>=50)
            {
                if(total>=180)
                {
                    Console.WriteLine("The student is eligible for admission");
                }
                else
                {
                    Console.WriteLine("Not eligible");
                }
            }
            else if(maths+physics>=140)
            {
                Console.WriteLine("The student is eligible for admission");
            }
            else
            {
                Console.WriteLine("Not eligible");
            }
        }
    }
}
