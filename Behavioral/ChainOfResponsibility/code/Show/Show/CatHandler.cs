namespace Show;

public class CatHandler: AbstractHandler
{
    public override object Handle(object request)
    {
        if (request.ToString() == "Catnip")
        {
            return $"Cat: I love {request.ToString()}.\n";
        }
        else
        {
            return base.Handle(request);
        }
    }
}