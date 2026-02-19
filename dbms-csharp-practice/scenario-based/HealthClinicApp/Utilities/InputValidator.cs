using System.Text.RegularExpressions;

namespace HealthClinicApp.Utilities;

public static class InputValidator
{
    public static bool IsValidEmail(string? email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;
        
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
    }

    public static bool IsValidPhone(string? phone)
    {
        if (string.IsNullOrWhiteSpace(phone))
            return false;
        
        return Regex.IsMatch(phone, @"^[\d\s\-+()]+$");
    }

    public static bool IsValidBloodGroup(string? bloodGroup)
    {
        if (string.IsNullOrWhiteSpace(bloodGroup))
            return true; // Optional field
        
        var validGroups = new[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };
        return validGroups.Contains(bloodGroup.ToUpper());
    }

    public static bool IsValidDate(DateTime date)
    {
        return date <= DateTime.Now && date >= DateTime.Now.AddYears(-120);
    }

    public static bool IsValidAmount(decimal amount)
    {
        return amount > 0 && amount <= 999999.99m;
    }
}

