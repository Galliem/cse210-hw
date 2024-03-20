namespace GoalProject;

public class Simple:Goal{
    public Simple():base(){}
    public void SimpleGoal(){
        Goal getDetails = new Goal();
    }
        public override string goalDetails()
        {
            return base.goalDetails();
        }   
}