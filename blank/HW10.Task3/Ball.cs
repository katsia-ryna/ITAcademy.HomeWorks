using System;
using System.Collections.Generic;
using System.Text;

namespace HW10.Task3
{
    class Ball
    {
        public string ballType { get; set;}
        public Ball (string ballType)
        {
            this.ballType = ballType;
        }
        public Ball()
        {
            ballType = "regular";
        }
    }
}
