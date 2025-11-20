using SignalRc.Models;

namespace SignalRc.Helpers;


public class ValidateModel
{
    public static List<string> Validate(SignalRcModel model)
    {
        var list = new List<string>();

        // validate id
        var parseId = Guid.TryParse(model.Self, out Guid guid);
        if (!parseId)
        {
            list.Add("self is not a valid GUID");
        }

// validate version
        if (string.IsNullOrEmpty(model.Version))
        {
            list.Add("version is not set");
        }

        // validate cars
        if (model.Vehicles.Count() < 1)
        {
            list.Add("cars count is not set");
        }

        return list;
    }
}