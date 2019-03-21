public class ExerciseException extends Exception
{
    public ExerciseException( )
    {
        super("Exercise exception thrown!");
        System.out.println("Exception thrown.");
    }
    public ExerciseException(String message)
    {
        super(message);
        System.out.println(
          "ExerciseException invoked with an argument.");
    }
}