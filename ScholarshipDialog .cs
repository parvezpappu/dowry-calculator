public class ScholarshipDialog : Form
{
    private RadioButton[] radioButtons;
    private Button selectButton;
    private Label titleLabel;

    public ScholarshipDialog()
    {
        this.Text = "Do You Have Any Scholarship?";
        this.Size = new Size(350, 300);
        this.StartPosition = FormStartPosition.CenterParent; // Center on parent form

        // Title label
        titleLabel = new Label();
        titleLabel.Text = "Do You Have Any Scholarship?";
        titleLabel.Font = new Font("Arial", 12, FontStyle.Bold);
        titleLabel.AutoSize = true;
        titleLabel.Location = new Point(10, 10);
        this.Controls.Add(titleLabel);

        // Scholarship options
        string[] scholarships =
        {
            "100%",
            "75%",
            "50%",
            "25%",
            "10%"
        };

        // Create and add radio buttons for scholarship options
        radioButtons = new RadioButton[scholarships.Length];
        int radioButtonTop = titleLabel.Bottom + 20;
        int gap = 25;

        for (int i = 0; i < scholarships.Length; i++)
        {
            radioButtons[i] = new RadioButton();
            radioButtons[i].Text = scholarships[i];
            radioButtons[i].AutoSize = true;
            radioButtons[i].Location = new Point(10, radioButtonTop + i * gap);
            this.Controls.Add(radioButtons[i]);
        }

        // Select button
        selectButton = new Button();
        selectButton.Text = "Select";
        selectButton.Size = new Size(100, 30);
        selectButton.Location = new Point((this.ClientSize.Width - selectButton.Width) / 2, radioButtonTop + scholarships.Length * gap + 20);
        selectButton.Click += SelectButton_Click;
        this.Controls.Add(selectButton);
    }

    private void SelectButton_Click(object sender, EventArgs e)
    {
        foreach (RadioButton rb in radioButtons)
        {
            if (rb.Checked)
            {
                MessageBox.Show($"You selected: {rb.Text} Scholarship");
                this.Hide(); // Hide dialog after selection
                break;
            }
        }
    }
}
