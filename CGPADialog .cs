public class CGPADialog : Form
{
    private RadioButton[] radioButtons;
    private Button selectButton;
    private Label titleLabel;

    public CGPADialog()
    {
        this.Text = "Select Your CGPA Range";
        this.Size = new Size(350, 350);
        this.StartPosition = FormStartPosition.CenterParent; // Center on parent form

        // Title label
        titleLabel = new Label();
        titleLabel.Text = "Select Your CGPA Range";
        titleLabel.Font = new Font("Arial", 12, FontStyle.Bold);
        titleLabel.AutoSize = true;
        titleLabel.Location = new Point(10, 10);
        this.Controls.Add(titleLabel);

        // CGPA ranges
        string[] cgpaRanges =
        {
            "Probation (Under 2.50)",
            "2.50 - 2.75",
            "2.75 - 3.00",
            "3.00 - 3.25",
            "3.25 - 3.50",
            "3.50 - 3.75",
            "3.75 - 4.00"
        };

        // Create and add radio buttons for CGPA ranges
        radioButtons = new RadioButton[cgpaRanges.Length];
        int radioButtonTop = titleLabel.Bottom + 20;
        int gap = 25;

        for (int i = 0; i < cgpaRanges.Length; i++)
        {
            radioButtons[i] = new RadioButton();
            radioButtons[i].Text = cgpaRanges[i];
            radioButtons[i].AutoSize = true;
            radioButtons[i].Location = new Point(10, radioButtonTop + i * gap);
            this.Controls.Add(radioButtons[i]);
        }

        // Select button
        selectButton = new Button();
        selectButton.Text = "Select";
        selectButton.Size = new Size(100, 30);
        selectButton.Location = new Point((this.ClientSize.Width - selectButton.Width) / 2, radioButtonTop + cgpaRanges.Length * gap + 20);
        selectButton.Click += SelectButton_Click;
        this.Controls.Add(selectButton);
    }


    private void SelectButton_Click(object sender, EventArgs e)
    {
        foreach (RadioButton rb in radioButtons)
        {
            if (rb.Checked)
            {
                MessageBox.Show($"You selected CGPA range: {rb.Text}");
                this.Hide(); // Hide dialog after selection
                break;
            }
        }
    }
}
