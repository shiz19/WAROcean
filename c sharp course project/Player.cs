using System;

namespace c_sharp_course_project
{
    public class Player
    {
        private string _name;
        private int _record;

        public Player(string name="Josh", int record=0)
        {
            _name = name;
            _record = record;

        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Record
        {
            get => _record;
            set
            {
                var checkRecord = value;
                if (checkRecord<=100&&checkRecord>0)
                {
                    _record = value;
                }
                else
                {
                    _record = 0;
                }
               
            }
        }
        
    }
}