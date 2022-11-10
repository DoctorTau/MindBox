namespace MindBox;

[System.Serializable]
public class FigureException : System.Exception
{
    public FigureException() { }
    public FigureException(string message) : base(message) { }
    public FigureException(string message, System.Exception inner) : base(message, inner) { }
    protected FigureException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}