using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix
{
    class VIDEOuser : Video
    {
        private string username;

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }
    }
}
