using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix
{
    interface Likeable 
    {
        public void Like(VIDEOuser user);
        public void Unlike(VIDEOuser user);
        public void Share(VIDEOuser user);
    }
}
