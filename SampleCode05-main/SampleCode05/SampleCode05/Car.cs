﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode05
{
    public class Car
    {
        public float Position = 0f;
        public float Speed = 10f; //秒速10m

        //コンストラクタ
        public Car(float speed)
        {
            this.Speed = speed;
        }

        public void Run(float time)
        {
            this.Position += time * this.Speed;
        }
    }

    public class Bike
    {

    }
}
