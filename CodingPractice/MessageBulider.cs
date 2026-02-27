class MessageBulider
{
    private string _message = "";

    public MessageBulider AddText(string text)
    {
        _message += text;
        return this;
    }

    public MessageBulider AddSpace()
    {
        _message += " ";
        return this;
    }

    public MessageBulider AddNewLine()
    {
        _message += "\n";
        return this;
    }

    public string Bulid()
    {
        return _message;
    }
}