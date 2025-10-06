using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Before
{
    public class Question
    {
        public string Title { set; get; }
        public int Mark { set; get; }
        public QuestionType QuestionType {set;get; }
        public List<string> Choices { set; get; }
    }
}
