namespace Show;

public abstract class AbstractHandler: Handler
{
    private Handler _nextHandler;
    
    public Handler SetNext(Handler handler)
    {
        this._nextHandler = handler;
        return handler;
    }

    public virtual object Handle(object request)
    {
        if (this._nextHandler != null)
        {
            return this._nextHandler.Handle(request);
        }
        else
        {
            return null;
        }
    }
}