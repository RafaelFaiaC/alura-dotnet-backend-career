namespace ScreenSound.Models;

internal interface IRatable
{
    double Average { get; }
    void AddRating(Rating rating);
}
