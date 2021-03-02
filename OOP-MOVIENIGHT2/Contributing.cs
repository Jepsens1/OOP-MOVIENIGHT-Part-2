using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MOVIENIGHT2
{
    class Contributing
    {

        private int fid;

        public int Fid
        {
            get { return fid; }
            set { fid = value; }
        }
        private int sid;

        public int Sid
        {
            get { return sid; }
            set { sid = value; }
        }
        public Contributing(int _sid, int _fid)
        {
            this.Fid = _fid;
            this.Sid = _sid;
        }
        public Contributing()
        {

        }
    }
}
