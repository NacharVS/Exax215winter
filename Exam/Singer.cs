using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Singer
    {
        private string _label;
        private string _style;
        private string _composition;
        private string _album;
        private int year;

        
        public string Label
        {
            get
            {
                return _label;
            }
            set
            {
                _label = value;
            }
        }

        public string Style { get => _style; set => _style = value; }
        public string Composition { get => _composition; set => _composition = value; }
        public string Album { get => _album; set => _album = value; }
        public int Year { get => year; set => year = value; }

    }
}
