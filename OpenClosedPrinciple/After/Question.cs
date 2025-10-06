namespace OpenClosedPrinciple.After
{

    // all question must has title and mark
    // then when you need to build any other question 
    // only inhrite form base question class 
    public abstract class Question
    {
        public string Title { set; get; }
        public int Mark { set; get; }
        public abstract void Print();
    }
}
