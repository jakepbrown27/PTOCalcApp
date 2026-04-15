namespace PTOApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        mainLayout = new TableLayoutPanel();
        inputPanel = new Panel();
        summaryPanel = new Panel();
        titleLabel = new Label();
        subtitleLabel = new Label();
        currentHoursLabel = new Label();
        currentHoursInput = new NumericUpDown();
        accrualRateLabel = new Label();
        accrualRateInput = new NumericUpDown();
        fiscalYearLabel = new Label();
        instructionLabel = new Label();
        ptoCalendar = new MonthCalendar();
        selectedDatesLabel = new Label();
        selectedDatesPanel = new Panel();
        selectedDatesList = new ListBox();
        clearSelectionButton = new Button();
        projectedHoursTextLabel = new Label();
        projectedHoursValueLabel = new Label();
        selectedDaysTextLabel = new Label();
        selectedDaysValueLabel = new Label();
        selectedHoursTextLabel = new Label();
        selectedHoursValueLabel = new Label();
        remainingHoursTextLabel = new Label();
        remainingHoursValueLabel = new Label();
        accrualScheduleLabel = new Label();
        balanceStatusLabel = new Label();
        selectedDatesPanel.SuspendLayout();
        mainLayout.SuspendLayout();
        inputPanel.SuspendLayout();
        summaryPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)currentHoursInput).BeginInit();
        ((System.ComponentModel.ISupportInitialize)accrualRateInput).BeginInit();
        SuspendLayout();
        // 
        // mainLayout
        // 
        mainLayout.ColumnCount = 2;
        mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 380F));
        mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        mainLayout.Controls.Add(inputPanel, 0, 0);
        mainLayout.Controls.Add(summaryPanel, 1, 0);
        mainLayout.Dock = DockStyle.Fill;
        mainLayout.Location = new Point(0, 0);
        mainLayout.Name = "mainLayout";
        mainLayout.Padding = new Padding(18);
        mainLayout.RowCount = 1;
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        mainLayout.Size = new Size(1240, 760);
        mainLayout.TabIndex = 0;
        // 
        // inputPanel
        // 
        inputPanel.BackColor = Color.White;
        inputPanel.Controls.Add(selectedDatesPanel);
        inputPanel.Controls.Add(clearSelectionButton);
        inputPanel.Controls.Add(selectedDatesLabel);
        inputPanel.Controls.Add(ptoCalendar);
        inputPanel.Controls.Add(instructionLabel);
        inputPanel.Controls.Add(fiscalYearLabel);
        inputPanel.Controls.Add(accrualRateInput);
        inputPanel.Controls.Add(accrualRateLabel);
        inputPanel.Controls.Add(currentHoursInput);
        inputPanel.Controls.Add(currentHoursLabel);
        inputPanel.Controls.Add(subtitleLabel);
        inputPanel.Controls.Add(titleLabel);
        inputPanel.Dock = DockStyle.Fill;
        inputPanel.Location = new Point(21, 21);
        inputPanel.Name = "inputPanel";
        inputPanel.Padding = new Padding(18);
        inputPanel.Size = new Size(374, 760);
        inputPanel.TabIndex = 0;
        // 
        // summaryPanel
        // 
        summaryPanel.BackColor = Color.FromArgb(239, 246, 255);
        summaryPanel.Controls.Add(balanceStatusLabel);
        summaryPanel.Controls.Add(accrualScheduleLabel);
        summaryPanel.Controls.Add(remainingHoursValueLabel);
        summaryPanel.Controls.Add(remainingHoursTextLabel);
        summaryPanel.Controls.Add(selectedHoursValueLabel);
        summaryPanel.Controls.Add(selectedHoursTextLabel);
        summaryPanel.Controls.Add(selectedDaysValueLabel);
        summaryPanel.Controls.Add(selectedDaysTextLabel);
        summaryPanel.Controls.Add(projectedHoursValueLabel);
        summaryPanel.Controls.Add(projectedHoursTextLabel);
        summaryPanel.Dock = DockStyle.Fill;
        summaryPanel.Location = new Point(401, 21);
        summaryPanel.Name = "summaryPanel";
        summaryPanel.Padding = new Padding(28);
        summaryPanel.Size = new Size(821, 760);
        summaryPanel.TabIndex = 1;
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
        titleLabel.ForeColor = Color.FromArgb(15, 23, 42);
        titleLabel.Location = new Point(18, 18);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(141, 41);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "PTO Plan";
        // 
        // subtitleLabel
        // 
        subtitleLabel.AutoSize = true;
        subtitleLabel.Font = new Font("Segoe UI", 9.75F);
        subtitleLabel.ForeColor = Color.FromArgb(71, 85, 105);
        subtitleLabel.Location = new Point(18, 62);
        subtitleLabel.MaximumSize = new Size(320, 0);
        subtitleLabel.Name = "subtitleLabel";
        subtitleLabel.Size = new Size(267, 46);
        subtitleLabel.TabIndex = 1;
        subtitleLabel.Text = "Enter your current balance and accrual rate, then click calendar days to plan time off.";
        // 
        // currentHoursLabel
        // 
        currentHoursLabel.AutoSize = true;
        currentHoursLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        currentHoursLabel.Location = new Point(18, 128);
        currentHoursLabel.Name = "currentHoursLabel";
        currentHoursLabel.Size = new Size(142, 23);
        currentHoursLabel.TabIndex = 2;
        currentHoursLabel.Text = "Current PTO hours";
        // 
        // currentHoursInput
        // 
        currentHoursInput.DecimalPlaces = 2;
        currentHoursInput.Font = new Font("Segoe UI", 11F);
        currentHoursInput.Location = new Point(22, 156);
        currentHoursInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        currentHoursInput.Name = "currentHoursInput";
        currentHoursInput.Size = new Size(320, 32);
        currentHoursInput.TabIndex = 3;
        // 
        // accrualRateLabel
        // 
        accrualRateLabel.AutoSize = true;
        accrualRateLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        accrualRateLabel.Location = new Point(18, 205);
        accrualRateLabel.Name = "accrualRateLabel";
        accrualRateLabel.Size = new Size(221, 23);
        accrualRateLabel.TabIndex = 4;
        accrualRateLabel.Text = "Accrual rate per pay period";
        // 
        // accrualRateInput
        // 
        accrualRateInput.DecimalPlaces = 2;
        accrualRateInput.Font = new Font("Segoe UI", 11F);
        accrualRateInput.Location = new Point(22, 233);
        accrualRateInput.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
        accrualRateInput.Name = "accrualRateInput";
        accrualRateInput.Size = new Size(320, 32);
        accrualRateInput.TabIndex = 5;
        accrualRateInput.Value = new decimal(new int[] { 8, 0, 0, 0 });
        // 
        // fiscalYearLabel
        // 
        fiscalYearLabel.AutoSize = true;
        fiscalYearLabel.Font = new Font("Segoe UI", 9.5F);
        fiscalYearLabel.ForeColor = Color.FromArgb(37, 99, 235);
        fiscalYearLabel.Location = new Point(18, 283);
        fiscalYearLabel.Name = "fiscalYearLabel";
        fiscalYearLabel.Size = new Size(162, 21);
        fiscalYearLabel.TabIndex = 6;
        fiscalYearLabel.Text = "Fiscal year end: Aug 31";
        // 
        // instructionLabel
        // 
        instructionLabel.AutoSize = true;
        instructionLabel.Font = new Font("Segoe UI", 9F);
        instructionLabel.ForeColor = Color.FromArgb(71, 85, 105);
        instructionLabel.Location = new Point(18, 315);
        instructionLabel.MaximumSize = new Size(320, 0);
        instructionLabel.Name = "instructionLabel";
        instructionLabel.Size = new Size(262, 40);
        instructionLabel.TabIndex = 7;
        instructionLabel.Text = "Click a day once to add PTO. Click it again to remove it. Each selected day counts as 8 hours.";
        // 
        // ptoCalendar
        // 
        ptoCalendar.CalendarDimensions = new Size(1, 1);
        ptoCalendar.Font = new Font("Segoe UI", 9F);
        ptoCalendar.Location = new Point(22, 366);
        ptoCalendar.MaxSelectionCount = 1;
        ptoCalendar.Name = "ptoCalendar";
        ptoCalendar.ShowTodayCircle = true;
        ptoCalendar.ShowWeekNumbers = true;
        ptoCalendar.Size = new Size(320, 220);
        ptoCalendar.TabIndex = 8;
        ptoCalendar.TitleBackColor = Color.FromArgb(37, 99, 235);
        ptoCalendar.TrailingForeColor = Color.FromArgb(148, 163, 184);
        // 
        // selectedDatesLabel
        // 
        selectedDatesLabel.AutoSize = true;
        selectedDatesLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        selectedDatesLabel.Location = new Point(18, 596);
        selectedDatesLabel.Name = "selectedDatesLabel";
        selectedDatesLabel.Size = new Size(128, 23);
        selectedDatesLabel.TabIndex = 9;
        selectedDatesLabel.Text = "Selected dates";
        // 
        // selectedDatesPanel
        // 
        selectedDatesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        selectedDatesPanel.Controls.Add(selectedDatesList);
        selectedDatesPanel.Location = new Point(22, 624);
        selectedDatesPanel.Name = "selectedDatesPanel";
        selectedDatesPanel.Size = new Size(320, 118);
        selectedDatesPanel.TabIndex = 10;
        // 
        // selectedDatesList
        // 
        selectedDatesList.Dock = DockStyle.Fill;
        selectedDatesList.Font = new Font("Segoe UI", 9.5F);
        selectedDatesList.FormattingEnabled = true;
        selectedDatesList.ItemHeight = 21;
        selectedDatesList.Location = new Point(0, 0);
        selectedDatesList.Name = "selectedDatesList";
        selectedDatesList.Size = new Size(320, 118);
        selectedDatesList.TabIndex = 0;
        // 
        // clearSelectionButton
        // 
        clearSelectionButton.BackColor = Color.FromArgb(219, 234, 254);
        clearSelectionButton.FlatAppearance.BorderSize = 0;
        clearSelectionButton.FlatStyle = FlatStyle.Flat;
        clearSelectionButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        clearSelectionButton.ForeColor = Color.FromArgb(30, 64, 175);
        clearSelectionButton.Location = new Point(231, 592);
        clearSelectionButton.Name = "clearSelectionButton";
        clearSelectionButton.Size = new Size(111, 30);
        clearSelectionButton.TabIndex = 11;
        clearSelectionButton.Text = "Clear dates";
        clearSelectionButton.UseVisualStyleBackColor = false;
        // 
        // projectedHoursTextLabel
        // 
        projectedHoursTextLabel.AutoSize = true;
        projectedHoursTextLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        projectedHoursTextLabel.ForeColor = Color.FromArgb(30, 41, 59);
        projectedHoursTextLabel.Location = new Point(31, 36);
        projectedHoursTextLabel.Name = "projectedHoursTextLabel";
        projectedHoursTextLabel.Size = new Size(242, 25);
        projectedHoursTextLabel.TabIndex = 0;
        projectedHoursTextLabel.Text = "Projected PTO by Aug. 31";
        // 
        // projectedHoursValueLabel
        // 
        projectedHoursValueLabel.AutoSize = true;
        projectedHoursValueLabel.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold);
        projectedHoursValueLabel.ForeColor = Color.FromArgb(29, 78, 216);
        projectedHoursValueLabel.Location = new Point(31, 66);
        projectedHoursValueLabel.Name = "projectedHoursValueLabel";
        projectedHoursValueLabel.Size = new Size(158, 62);
        projectedHoursValueLabel.TabIndex = 1;
        projectedHoursValueLabel.Text = "0 hrs";
        // 
        // selectedDaysTextLabel
        // 
        selectedDaysTextLabel.AutoSize = true;
        selectedDaysTextLabel.Font = new Font("Segoe UI", 11F);
        selectedDaysTextLabel.ForeColor = Color.FromArgb(51, 65, 85);
        selectedDaysTextLabel.Location = new Point(32, 167);
        selectedDaysTextLabel.Name = "selectedDaysTextLabel";
        selectedDaysTextLabel.Size = new Size(120, 25);
        selectedDaysTextLabel.TabIndex = 2;
        selectedDaysTextLabel.Text = "Selected days";
        // 
        // selectedDaysValueLabel
        // 
        selectedDaysValueLabel.AutoSize = true;
        selectedDaysValueLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
        selectedDaysValueLabel.ForeColor = Color.FromArgb(15, 23, 42);
        selectedDaysValueLabel.Location = new Point(32, 194);
        selectedDaysValueLabel.Name = "selectedDaysValueLabel";
        selectedDaysValueLabel.Size = new Size(114, 37);
        selectedDaysValueLabel.TabIndex = 3;
        selectedDaysValueLabel.Text = "0 day(s)";
        // 
        // selectedHoursTextLabel
        // 
        selectedHoursTextLabel.AutoSize = true;
        selectedHoursTextLabel.Font = new Font("Segoe UI", 11F);
        selectedHoursTextLabel.ForeColor = Color.FromArgb(51, 65, 85);
        selectedHoursTextLabel.Location = new Point(32, 264);
        selectedHoursTextLabel.Name = "selectedHoursTextLabel";
        selectedHoursTextLabel.Size = new Size(126, 25);
        selectedHoursTextLabel.TabIndex = 4;
        selectedHoursTextLabel.Text = "Selected hours";
        // 
        // selectedHoursValueLabel
        // 
        selectedHoursValueLabel.AutoSize = true;
        selectedHoursValueLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
        selectedHoursValueLabel.ForeColor = Color.FromArgb(15, 23, 42);
        selectedHoursValueLabel.Location = new Point(32, 291);
        selectedHoursValueLabel.Name = "selectedHoursValueLabel";
        selectedHoursValueLabel.Size = new Size(89, 37);
        selectedHoursValueLabel.TabIndex = 5;
        selectedHoursValueLabel.Text = "0 hrs";
        // 
        // remainingHoursTextLabel
        // 
        remainingHoursTextLabel.AutoSize = true;
        remainingHoursTextLabel.Font = new Font("Segoe UI", 11F);
        remainingHoursTextLabel.ForeColor = Color.FromArgb(51, 65, 85);
        remainingHoursTextLabel.Location = new Point(32, 361);
        remainingHoursTextLabel.Name = "remainingHoursTextLabel";
        remainingHoursTextLabel.Size = new Size(149, 25);
        remainingHoursTextLabel.TabIndex = 6;
        remainingHoursTextLabel.Text = "Remaining hours";
        // 
        // remainingHoursValueLabel
        // 
        remainingHoursValueLabel.AutoSize = true;
        remainingHoursValueLabel.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
        remainingHoursValueLabel.ForeColor = Color.FromArgb(15, 23, 42);
        remainingHoursValueLabel.Location = new Point(32, 389);
        remainingHoursValueLabel.Name = "remainingHoursValueLabel";
        remainingHoursValueLabel.Size = new Size(109, 46);
        remainingHoursValueLabel.TabIndex = 7;
        remainingHoursValueLabel.Text = "0 hrs";
        // 
        // accrualScheduleLabel
        // 
        accrualScheduleLabel.AutoSize = true;
        accrualScheduleLabel.Font = new Font("Segoe UI", 10F);
        accrualScheduleLabel.ForeColor = Color.FromArgb(71, 85, 105);
        accrualScheduleLabel.Location = new Point(32, 476);
        accrualScheduleLabel.Name = "accrualScheduleLabel";
        accrualScheduleLabel.Size = new Size(223, 23);
        accrualScheduleLabel.TabIndex = 8;
        accrualScheduleLabel.Text = "Future accrual dates remaining: 0";
        // 
        // balanceStatusLabel
        // 
        balanceStatusLabel.AutoSize = true;
        balanceStatusLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        balanceStatusLabel.Location = new Point(32, 520);
        balanceStatusLabel.MaximumSize = new Size(560, 0);
        balanceStatusLabel.Name = "balanceStatusLabel";
        balanceStatusLabel.Size = new Size(118, 25);
        balanceStatusLabel.TabIndex = 9;
        balanceStatusLabel.Text = "Status detail";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(224, 242, 254);
        ClientSize = new Size(1240, 760);
        Controls.Add(mainLayout);
        MinimumSize = new Size(1258, 807);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "PTO Planner";
        selectedDatesPanel.ResumeLayout(false);
        mainLayout.ResumeLayout(false);
        inputPanel.ResumeLayout(false);
        inputPanel.PerformLayout();
        summaryPanel.ResumeLayout(false);
        summaryPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)currentHoursInput).EndInit();
        ((System.ComponentModel.ISupportInitialize)accrualRateInput).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel mainLayout;
    private Panel inputPanel;
    private Panel summaryPanel;
    private Label titleLabel;
    private Label subtitleLabel;
    private Label currentHoursLabel;
    private NumericUpDown currentHoursInput;
    private Label accrualRateLabel;
    private NumericUpDown accrualRateInput;
    private Label fiscalYearLabel;
    private Label instructionLabel;
    private MonthCalendar ptoCalendar;
    private Label selectedDatesLabel;
    private Panel selectedDatesPanel;
    private ListBox selectedDatesList;
    private Button clearSelectionButton;
    private Label projectedHoursTextLabel;
    private Label projectedHoursValueLabel;
    private Label selectedDaysTextLabel;
    private Label selectedDaysValueLabel;
    private Label selectedHoursTextLabel;
    private Label selectedHoursValueLabel;
    private Label remainingHoursTextLabel;
    private Label remainingHoursValueLabel;
    private Label accrualScheduleLabel;
    private Label balanceStatusLabel;
}
