namespace RelativeDateAndNumbers;

public static class RelativeDate
{
    public static string AsRelative(this DateTime dateTime, string language = "us", bool shortForm = true)
    {
        var timeSpan = DateTime.Now - dateTime;

        if (language.ToLower() == "es")
        {

            if (timeSpan.TotalSeconds < 60)
                return $"{(int)timeSpan.TotalSeconds} {(shortForm ? "s" : " segundos")}"; // Segundos

            if (timeSpan.TotalMinutes < 60)
                return $"{(int)timeSpan.TotalMinutes} {(shortForm ? "m" : " minutos")}"; // Minutos

            if (timeSpan.TotalHours < 24)
                return $"{(int)timeSpan.TotalHours} {(shortForm ? "h" : " horas")}"; // Horas

            if (timeSpan.TotalDays < 30)
                return $"{(int)timeSpan.TotalDays} {(shortForm ? "d" : " días")}"; // Días

            if (timeSpan.TotalDays < 365)
                return $"{(int)(timeSpan.TotalDays / 30)} {(shortForm ? "M" : " Meses")}"; // Meses

            return $"{(int)(timeSpan.TotalDays / 365)} {(shortForm ? "Y" : " Años")}"; // Años
        }
        

        if (timeSpan.TotalSeconds < 60)
            return $"{(int)timeSpan.TotalSeconds} {(shortForm ? "s" : " seconds")}"; // Segundos

        if (timeSpan.TotalMinutes < 60)
            return $"{(int)timeSpan.TotalMinutes} {(shortForm ? "m" : " minutes")}"; // Minutos

        if (timeSpan.TotalHours < 24)
            return $"{(int)timeSpan.TotalHours} {(shortForm ? "h" : " hours")}"; // Horas

        if (timeSpan.TotalDays < 30)
            return $"{(int)timeSpan.TotalDays} {(shortForm ? "d" : " days")}"; // Días

        if (timeSpan.TotalDays < 365)
            return $"{(int)(timeSpan.TotalDays / 30)} {(shortForm ? "M" : " Months")}"; // Meses

        return $"{(int)(timeSpan.TotalDays / 365)} {(shortForm ? "Y" : " Years")}"; // Años
    }


   
}