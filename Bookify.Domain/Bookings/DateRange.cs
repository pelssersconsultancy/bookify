namespace Bookify.Domain.Bookings;

public record DateRange()
{
    private DateRange(DateOnly start, DateOnly end) : this()
    {
        Start = start;
        End = end;
    }
    

    public DateOnly Start { get; init; }
    
    public DateOnly End { get; init; }
    
    public int LengthInDays => End.DayNumber - Start.DayNumber;

    public static DateRange Create(DateOnly start, DateOnly end)
    {
        if (start > end)
        {
            throw new ApplicationException("End date precedes start date");
        }
        
        return new DateRange( start, end);
    }
    
}