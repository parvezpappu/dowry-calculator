public class SemesterDialog : Form
{
    public SemesterDialog()
    {
        this.Text = "Select Your Current Semester";
        this.Size = new Size(300, 400);
        this.StartPosition = FormStartPosition.CenterParent; // Center on parent form

        // Add semester buttons
        int buttonHeight = 25;
        int buttonWidth = 100;
        int gap = 10;
        for (int i = 1; i <= 12; i++)
        {
            Button semesterButton = new Button();
            semesterButton.Text = i.ToString();
            semesterButton.Size = new Size(buttonWidth, buttonHeight);
            semesterButton.Location = new Point((this.ClientSize.Width - buttonWidth) / 2, 10 + (i - 1) * (buttonHeight + gap));
            semesterButton.Click += SemesterButton_Click;
            this.Controls.Add(semesterButton);
        }
    }

    private void SemesterButton_Click(object sender, EventArgs e)
    {
        // Handle semester selection
        MessageBox.Show($"You selected semester: {((Button)sender).Text}");
        this.Hide(); // Hide dialog after selection
    }
}
