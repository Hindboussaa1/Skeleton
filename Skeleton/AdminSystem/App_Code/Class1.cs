using System.Web.UI.WebControls;

public class CustomValidator : BaseValidator
{
    public CustomValidator(string errorMessage)
    {
        ErrorMessage = errorMessage;
        Display = ValidatorDisplay.Dynamic;
    }

    protected override bool ControlPropertiesValid()
    {
        // Always return true since we don't need to check control properties
        return true;
    }

    protected override bool EvaluateIsValid()
    {
        // Always return false since we don't need to perform any validation here
        return false;
    }
}