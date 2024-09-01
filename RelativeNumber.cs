namespace RelativeDateAndNumbers;

public static class RelativeNumber
{
    public static string AsRelative(this int num, string language = "us", bool shortForm = true)
    {

        if (shortForm)
        {
            if (num >= 1_000_000_000)
                return $"{num / 1_000_000_000} {(language.ToLower() == "es" ? "Mm" : "B")}";
            if (num >= 1_000_000)
                return $"{num / 1_000_000} {(language.ToLower() == "es" ? "M" : "M")}";
            if (num >= 1_000)
                return $"{num / 1_000} {(language.ToLower() == "es" ? "m" : "k")}";
        }
        else
        {
            if (num >= 1_000_000_000)
                return $"{num / 1_000_000_000} {(language.ToLower() == "es" ? "Mil millones" : "billion")}";
            if (num >= 1_000_000)
                return $"{num / 1_000_000} {(language.ToLower() == "es" ? "Millones" : "million")}";
            if (num >= 1_000)
                return $"{num / 1_000} {(language.ToLower() == "es" ? "mil" : "thousand")}";
        }
        return num.ToString();
    }

}