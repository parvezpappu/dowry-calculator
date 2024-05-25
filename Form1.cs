namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private TextBox nameTextBox; // Declare the TextBox at class level
        private SemesterDialog semesterDialog; // Declare the SemesterDialog at class level
        private DepartmentDialog departmentDialog; // Declare the DepartmentDialog at class level
        private CGPADialog cgpaDialog; // Declare the CGPADialog at class level
        private ScholarshipDialog scholarshipDialog; // Declare the ScholarshipDialog at class level

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
            this.ClientSize = new Size(850, 700); // Set initial size
        }

        private void InitializeCustomComponents()
        {
            this.Text = "Jowtuk Koto !";

            // Set form background color to dark blue
            this.BackColor = Color.FromArgb(18, 32, 47); // Dark Blue

            // Add a label with the welcome text
            Label welcomeLabel = new Label();
            welcomeLabel.Text = "Welcome to Jowtuk Koto !?";
            welcomeLabel.ForeColor = Color.FromArgb(153, 170, 181); // Lighter shade of the background color
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point((this.ClientSize.Width - welcomeLabel.Width) / 2, 50);
            this.Controls.Add(welcomeLabel);

            // Define the button texts
            string[] buttonNames = { "Name", "Department", "Current Semester", "CGPA", "Academic Scholarship" };
            int buttonTop = welcomeLabel.Bottom + 40; // Start below the welcome label
            int buttonHeight = 40;
            int gap = 20; // Gap between buttons

            // Create and add the buttons
            for (int i = 0; i < buttonNames.Length; i++)
            {
                CircularButton button = new CircularButton();
                button.Text = buttonNames[i];
                button.ForeColor = Color.White;
                button.BackColor = Color.DarkGreen;
                button.Font = new Font("Arial", 12, FontStyle.Regular);
                button.Size = new Size(200, buttonHeight);
                button.Location = new Point(50, buttonTop + i * (buttonHeight + gap));
                button.MouseEnter += (sender, e) => FlipButtonText(button);
                button.MouseLeave += (sender, e) => FlipButtonText(button);
                this.Controls.Add(button);

                if (buttonNames[i] == "Name")
                {
                    button.Click += NameButton_Click;
                }
                else if (buttonNames[i] == "Department")
                {
                    button.Click += DepartmentButton_Click;
                }
                else if (buttonNames[i] == "Current Semester")
                {
                    button.Click += CurrentSemesterButton_Click;
                }
                else if (buttonNames[i] == "CGPA")
                {
                    button.Click += CGPAButton_Click;
                }
                else if (buttonNames[i] == "Academic Scholarship")
                {
                    button.Click += ScholarshipButton_Click;
                }
            }
        }

        private void FlipButtonText(Button button)
        {
            button.Text = new string(button.Text.Reverse().ToArray());
        }

        private void NameButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox == null)
            {
                nameTextBox = new TextBox();
                nameTextBox.Size = new Size(200, 30);
                nameTextBox.Location = new Point(270, ((CircularButton)sender).Top); // Position to the right of the button
                nameTextBox.Font = new Font("Arial", 12, FontStyle.Regular);
                nameTextBox.BackColor = Color.FromArgb(153, 170, 181); // Match the label's forecolor
                nameTextBox.ForeColor = Color.Black;
                nameTextBox.BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(nameTextBox);
            }
            nameTextBox.Visible = !nameTextBox.Visible; // Toggle visibility
            if (nameTextBox.Visible)
            {
                nameTextBox.Focus();
            }
        }

        private void DepartmentButton_Click(object sender, EventArgs e)
        {
            if (departmentDialog == null)
            {
                departmentDialog = new DepartmentDialog();
                departmentDialog.FormClosed += (s, args) => departmentDialog = null; // Reset dialog on close
            }
            if (!departmentDialog.Visible)
            {
                departmentDialog.ShowDialog(this); // Show as dialog centered on parent
            }
            else
            {
                departmentDialog.Hide(); // Hide if already visible
            }
        }

        private void CurrentSemesterButton_Click(object sender, EventArgs e)
        {
            if (semesterDialog == null)
            {
                semesterDialog = new SemesterDialog();
                semesterDialog.FormClosed += (s, args) => semesterDialog = null; // Reset dialog on close
            }
            if (!semesterDialog.Visible)
            {
                semesterDialog.ShowDialog(this); // Show as dialog centered on parent
            }
            else
            {
                semesterDialog.Hide(); // Hide if already visible
            }
        }

        private void CGPAButton_Click(object sender, EventArgs e)
        {
            if (cgpaDialog == null)
            {
                cgpaDialog = new CGPADialog();
                cgpaDialog.FormClosed += (s, args) => cgpaDialog = null; // Reset dialog on close
            }
            if (!cgpaDialog.Visible)
            {
                cgpaDialog.ShowDialog(this); // Show as dialog centered on parent
            }
            else
            {
                cgpaDialog.Hide(); // Hide if already visible
            }
        }

        private void ScholarshipButton_Click(object sender, EventArgs e)
        {
            if (scholarshipDialog == null)
            {
                scholarshipDialog = new ScholarshipDialog();
                scholarshipDialog.FormClosed += (s, args) => scholarshipDialog = null; // Reset dialog on close
            }
            if (!scholarshipDialog.Visible)
            {
                scholarshipDialog.ShowDialog(this); // Show as dialog centered on parent
            }
            else
            {
                scholarshipDialog.Hide(); // Hide if already visible
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // Additional initialization if needed
        }
    }
}


