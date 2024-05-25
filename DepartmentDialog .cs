public class DepartmentDialog : Form
{
    public DepartmentDialog()
    {
        this.Text = "Select Your Department";
        this.Size = new Size(300, 300);
        this.StartPosition = FormStartPosition.CenterParent; // Center on parent form

        // Add department buttons
        string[] departments = { "CSE", "EEE", "BBA", "ENGLISH", "ECONOMICS", "IPE" };
        int buttonHeight = 30;
        int buttonWidth = 200;
        int gap = 10;

        for (int i = 0; i < departments.Length; i++)
        {
            Button deptButton = new Button();
            deptButton.Text = departments[i];
            deptButton.Size = new Size(buttonWidth, buttonHeight);
            deptButton.Location = new Point((this.ClientSize.Width - buttonWidth) / 2, 20 + i * (buttonHeight + gap));
            deptButton.Click += DeptButton_Click;
            this.Controls.Add(deptButton);
        }
    }

    private void DeptButton_Click(object sender, EventArgs e)
    {
        // Handle department selection
        MessageBox.Show($"You selected: {((Button)sender).Text}");
        this.Hide(); // Hide dialog after selection
    }
}
