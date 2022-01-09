using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTGD_DOMIN
{
    class Diem
    {
        private int time;
        private int score;

        public Diem()
        {
            time = 0;
            score = 0;
        }
        public int getTime()
        {
            return this.time;
        }

        public void setTime(int time)
        {
            this.time = time;
        }

        public int getScore()
        {
            return this.score;
        }

        public void setScore(int score)
        {
            this.score = score;
        }

        public void setDiem(int time, int score)
        {
            this.setTime(time);
            this.setScore(score);
        }

        public void switchDiem(Diem diem)
        {
            Diem temp = new Diem();

            temp.setTime(this.getTime());
            temp.setScore(this.getScore());
            //------------------
            this.setTime(diem.getTime());
            this.setScore(diem.getScore());
            //------------------
            diem.setTime(temp.getTime());
            diem.setScore(temp.getScore());
        }
        

    }
}
