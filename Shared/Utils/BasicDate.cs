using System.ComponentModel.DataAnnotations.Schema;

namespace Gaby.Shared.Utils;

public class BasicDate
{
    public int Day { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }
    
    public override string ToString()
    {
        return Day + "/" + Month + "/" + Year;
    }
}