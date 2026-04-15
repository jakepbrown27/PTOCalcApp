using System.Globalization;

namespace PTOApp;

public partial class Form1 : Form
{
    private const decimal HoursPerPtoDay = 8m;
    private const decimal CarryoverLimitHours = 200m;
    private static readonly decimal[] AllowedAccrualRates = [5.67m, 6.33m, 6.67m, 7.00m, 7.67m, 8.33m, 9.00m];
    private readonly HashSet<DateTime> selectedPtoDates = [];

    public Form1()
    {
        InitializeComponent();
        ConfigureForm();
        RecalculateSummary();
    }

    private void ConfigureForm()
    {
        currentHoursInput.ValueChanged += (_, _) => RecalculateSummary();
        currentHoursInput.TextChanged += (_, _) => RecalculateSummary();
        ConfigureAccrualRateInput();
        ptoCalendar.DateSelected += Calendar_DateSelected;
        clearSelectionButton.Click += (_, _) =>
        {
            selectedPtoDates.Clear();
            RefreshCalendar();
            RecalculateSummary();
        };

        var fiscalYearEnd = GetFiscalYearEnd(DateTime.Today);
        fiscalYearLabel.Text = $"Fiscal year end: {fiscalYearEnd:MMMM d, yyyy}";
        ptoCalendar.SetDate(DateTime.Today);
        ptoCalendar.MinDate = DateTime.Today;
        ptoCalendar.MaxDate = fiscalYearEnd;
    }

    private void ConfigureAccrualRateInput()
    {
        accrualRateInput.Items.Clear();
        foreach (var rate in AllowedAccrualRates)
        {
            accrualRateInput.Items.Add(rate.ToString("0.00", CultureInfo.InvariantCulture));
        }

        accrualRateInput.SelectedItem = "8.33";
        accrualRateInput.Text = "8.33";
        accrualRateInput.SelectedItemChanged += (_, _) => RecalculateSummary();
        accrualRateInput.TextChanged += (_, _) => RecalculateSummary();
    }

    private void Calendar_DateSelected(object? sender, DateRangeEventArgs e)
    {
        var selectedDate = e.Start.Date;

        if (selectedDate < DateTime.Today || selectedDate > GetFiscalYearEnd(DateTime.Today))
        {
            return;
        }

        if (!selectedPtoDates.Add(selectedDate))
        {
            selectedPtoDates.Remove(selectedDate);
        }

        RefreshCalendar();
        RecalculateSummary();
    }

    private void RefreshCalendar()
    {
        var orderedDates = selectedPtoDates.OrderBy(date => date).ToArray();
        ptoCalendar.RemoveAllBoldedDates();
        ptoCalendar.BoldedDates = orderedDates;
        ptoCalendar.UpdateBoldedDates();

        selectedDatesList.Items.Clear();
        foreach (var date in orderedDates)
        {
            selectedDatesList.Items.Add(date.ToString("dddd, MMM d, yyyy", CultureInfo.CurrentCulture));
        }
    }

    private void RecalculateSummary()
    {
        var today = DateTime.Today;
        var fiscalYearEnd = GetFiscalYearEnd(today);
        var accrualRate = GetSelectedAccrualRate();
        var currentHours = GetCurrentHours();
        var futureAccruals = CountRemainingAccrualPeriods(today, fiscalYearEnd);
        var projectedHours = currentHours + (futureAccruals * accrualRate);
        var selectedHours = selectedPtoDates.Count * HoursPerPtoDay;
        var remainingHours = projectedHours - selectedHours;

        fiscalYearLabel.Text = $"Fiscal year end: {fiscalYearEnd:MMMM d, yyyy}";
        accrualScheduleLabel.Text = $"Future accrual dates remaining: {futureAccruals}";
        projectedHoursValueLabel.Text = $"{projectedHours:0.##} hrs";
        selectedDaysValueLabel.Text = $"{selectedPtoDates.Count} day(s)";
        selectedHoursValueLabel.Text = $"{selectedHours:0.##} hrs";
        remainingHoursValueLabel.Text = $"{remainingHours:0.##} hrs";

        if (remainingHours < 0)
        {
            balanceStatusLabel.Text = "Selected PTO exceeds projected balance.";
            balanceStatusLabel.ForeColor = Color.FromArgb(183, 28, 28);
        }
        else if (remainingHours > CarryoverLimitHours)
        {
            balanceStatusLabel.Text = "Projected carryover is over 200 hours and would exceed the cap.";
            balanceStatusLabel.ForeColor = Color.FromArgb(180, 83, 9);
        }
        else
        {
            balanceStatusLabel.Text = "Balance is within the 200-hour carryover limit.";
            balanceStatusLabel.ForeColor = Color.FromArgb(27, 94, 32);
        }
    }

    private decimal GetSelectedAccrualRate()
    {
        return decimal.TryParse(accrualRateInput.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out var rate)
            ? rate
            : 8.33m;
    }

    private decimal GetCurrentHours()
    {
        return decimal.TryParse(currentHoursInput.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out var hours)
            ? hours
            : currentHoursInput.Value;
    }

    private static DateTime GetFiscalYearEnd(DateTime today)
    {
        var fiscalYear = today.Month > 8 ? today.Year + 1 : today.Year;
        return new DateTime(fiscalYear, 8, 31);
    }

    private static int CountRemainingAccrualPeriods(DateTime startDate, DateTime endDate)
    {
        var count = 0;
        var monthCursor = new DateTime(startDate.Year, startDate.Month, 1);

        while (monthCursor <= endDate)
        {
            count += CountAccrualIfInRange(new DateTime(monthCursor.Year, monthCursor.Month, 7), startDate, endDate);
            count += CountAccrualIfInRange(new DateTime(monthCursor.Year, monthCursor.Month, 21), startDate, endDate);
            monthCursor = monthCursor.AddMonths(1);
        }

        return count;
    }

    private static int CountAccrualIfInRange(DateTime accrualDate, DateTime startDate, DateTime endDate)
    {
        return accrualDate >= startDate && accrualDate <= endDate ? 1 : 0;
    }
}
