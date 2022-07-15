using System;
using System.Collections.Generic;
using System.Text;

namespace Taaghche.Core
{
    public class Like
    {
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int Order{ get; set; }

        public void Save()
        {

        }
    }
    public class LikeDTO
    {
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int Order { get; set; }
        public DateTime Created { get; set; }
    }
}
