using System;

public class CustomValidator : IValidator
{
    private string _errorMessage;

    public CustomValidator(string errorMessage)
    {
        _errorMessage = errorMessage;
    }

    public string ErrorMessage
    {
        get { return _errorMessage; }
        set { _errorMessage = value; }
    }

    public bool IsValid
    {
        get { return false; }
        set { }
    }

    public void Validate()
    {
        // Do nothing
    }